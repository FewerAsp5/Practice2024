using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Timers;

namespace PracticeTools
{
    public class DatabaseWatcher : IDisposable
    {
        private readonly Func<DataTable> reader;
        private readonly Func<DataTable, DataRow, object> findRow;
        private DataTable latestState;
        private readonly Timer checker;

        public DatabaseWatcher(Func<DataTable> reader, Func<DataTable, DataRow, object> findRow, int period) 
        { 
            this.reader = reader;
            this.findRow = findRow;
            checker = new Timer(period);
            checker.Elapsed += Checker_Elapsed;
        }

        private void Checker_Elapsed(object sender, ElapsedEventArgs e)
        {
            checker.Stop();
            try
            {
                var currentState = reader.Invoke();
                if (currentState.Rows.Count < latestState.Rows.Count && OnDataNew != null)
                {
                    if (OnDataAbsent != null)
                    {
                        foreach (var row in latestState.Rows)
                        {
                            var lastR = (DataRow)row;
                            var curR = findRow(currentState, lastR);
                            if (curR == null)
                                OnDataAbsent(this, lastR);
                        }
                    }
                }
                else if (OnDataChanged != null || OnDataNew != null)
                {
                    foreach (var row in currentState.Rows)
                    {
                        var curR = (DataRow)row;
                        var lastR = (DataRow)findRow(latestState, curR);
                        if (lastR == null)
                        {
                            if (OnDataNew != null)
                                OnDataNew(this, curR);
                        }
                        else if (OnDataChanged != null)
                        {
                            for (int c = 0; c < currentState.Columns.Count; c++)
                            {
                                var lastCell = lastR[c];
                                var curCell = curR[c];
                                if (!lastCell.Equals(curCell))
                                {
                                    OnDataChanged(this, curR);

                                    break;
                                }
                            }
                        }
                    }
                }
                latestState = currentState;
            }
            finally
            {
                checker.Start();
            }
        }

        public delegate void OnDataChangedDelegate(DatabaseWatcher sender, DataRow changedRow);
        public delegate void OnNewDataPresetnsDelegate(DatabaseWatcher sender, DataRow newRow);
        public delegate void OnExistingDataAbsentsDelegate(DatabaseWatcher sender, DataRow absentRow);

        public event OnDataChangedDelegate OnDataChanged;
        public event OnNewDataPresetnsDelegate OnDataNew;
        public event OnExistingDataAbsentsDelegate OnDataAbsent;

        public void Dispose()
        {
            StartWatching();
            checker.Dispose();
        }

        public void StartWatching()
        {
            latestState = reader.Invoke();
            checker.Start();
        }

        public void StopWatching() 
        {
            checker.Stop();
        }
    }
}
