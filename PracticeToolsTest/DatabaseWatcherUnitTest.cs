using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace PracticeToolsTest
{
    [TestClass]
    public class DatabaseWatcherUnitTest
    {
        private const int Period = 2000;
        private const int TestRowCount = 5;

        bool wasDatabaseRead = false;
        int findRowCallCount = 0;

        private readonly DataTable FirstStepDataTable = new DataTable();
        private readonly DataTable SecondStepDataTable = new DataTable();

        private readonly List<DataRow> ChangedRow = new List<DataRow>();
        private readonly List<DataRow> AbsentRow = new List<DataRow>();
        private readonly List<DataRow> NewRow = new List<DataRow>();

        public DatabaseWatcherUnitTest()
        {
            FirstStepDataTable.Columns.Add(new DataColumn("TestKey"));
            FirstStepDataTable.Columns.Add(new DataColumn("TestData"));
            FirstStepDataTable.PrimaryKey = new DataColumn[] { FirstStepDataTable.Columns[0] };
            SecondStepDataTable.Columns.Add(new DataColumn("TestKey"));
            SecondStepDataTable.Columns.Add(new DataColumn("TestData"));
            SecondStepDataTable.PrimaryKey = new DataColumn[] { SecondStepDataTable.Columns[0] };
        }

        private DataTable FakeReadDatabase()
        {
            if (wasDatabaseRead)
            {
                return SecondStepDataTable;
            }
            else
            {
                wasDatabaseRead = true;
                return FirstStepDataTable;
            }
        }

        private object FakeFindRow(DataTable source, DataRow key)
        {
            ++findRowCallCount;
            return source.Rows.Find(key[0]);
        }

        private void DataChangeHandler(DatabaseWatcher sender, DataRow changedRow)
        {
            ChangedRow.Add(changedRow);
        }
        private void DataAbsentHandler(DatabaseWatcher sender, DataRow absentRow)
        {
            AbsentRow.Add(absentRow);
        }
        private void DataNewHandler(DatabaseWatcher sender, DataRow newRow)
        {
            NewRow.Add(newRow);
        }

        private DatabaseWatcher PrepareDatabaseWatcherForTest(Func<DataTable> reader, Func<DataTable, DataRow, object> findRow)
        {
            DatabaseWatcher w = new DatabaseWatcher(reader, findRow, Period);
            w.OnDataAbsent += DataAbsentHandler;
            w.OnDataNew += DataNewHandler;
            w.OnDataChanged += DataChangeHandler;
            return w;
        }

        private void FillDataTables()
        {
            for (int i = 1; i <= TestRowCount; i++)
            {
                FirstStepDataTable.Rows.Add(i, -i);;
                SecondStepDataTable.Rows.Add(i, -i);
            }
        }

        [TestMethod]
        public void StartWatchTest()
        {
            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            Thread.Sleep(Period * 3 / 2);
            Assert.IsFalse(wasDatabaseRead);
            Assert.AreEqual(findRowCallCount, 0);

            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);
            Assert.IsTrue(wasDatabaseRead);
            Assert.AreEqual(findRowCallCount, TestRowCount);

            Thread.Sleep(Period);
            Assert.AreEqual(findRowCallCount, TestRowCount * 2);
        }

        [TestMethod]
        public void StopWatchTest()
        {
            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);

            Assert.AreEqual(findRowCallCount, TestRowCount);
            w.StopWatching();

            Thread.Sleep(Period * 2);
            Assert.AreEqual(findRowCallCount, TestRowCount);
        }

        [TestMethod]
        public void NoChangesTest()
        {
            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);

            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);

            Thread.Sleep(Period);
            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);
            w.StopWatching();
        }

        [TestMethod]
        public void ChangeRowTest()
        {
            var changeData = "500";

            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            SecondStepDataTable.Rows[2]["TestData"] = changeData;
            SecondStepDataTable.Rows[4]["TestData"] = changeData;
            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);

            Assert.AreEqual(2, ChangedRow.Count);
            Assert.AreEqual(changeData, ChangedRow[0]["TestData"]);
            Assert.AreEqual("3", ChangedRow[0]["TestKey"]);
            Assert.AreEqual(changeData, ChangedRow[1]["TestData"]);
            Assert.AreEqual("5", ChangedRow[1]["TestKey"]);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);
            ChangedRow.Clear();

            Thread.Sleep(Period);
            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);
            w.StopWatching();
        }

        [TestMethod]
        public void NewRowTest()
        {
            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            SecondStepDataTable.Rows.Add(6, 600);
            SecondStepDataTable.Rows.Add(7, 700);
            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);

            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(2, NewRow.Count);
            Assert.AreEqual("6", NewRow[0]["TestKey"]);
            Assert.AreEqual("7", NewRow[1]["TestKey"]);
            Assert.AreEqual(0, AbsentRow.Count);
            NewRow.Clear();

            Thread.Sleep(Period);
            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);
            w.StopWatching();
        }

        [TestMethod]
        public void AbsentRowTest()
        {
            var w = PrepareDatabaseWatcherForTest(FakeReadDatabase, FakeFindRow);
            FillDataTables();
            var delRow = SecondStepDataTable.Rows[1];
            var delKeyData = delRow["TestKey"];
            SecondStepDataTable.Rows.Remove(delRow);
            w.StartWatching();
            Thread.Sleep(Period * 3 / 2);

            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(1, AbsentRow.Count);
            Assert.AreEqual(delKeyData, AbsentRow[0]["TestKey"]);
            AbsentRow.Clear();

            Thread.Sleep(Period);
            Assert.AreEqual(0, ChangedRow.Count);
            Assert.AreEqual(0, NewRow.Count);
            Assert.AreEqual(0, AbsentRow.Count);
            w.StopWatching();
        }
    }
}
