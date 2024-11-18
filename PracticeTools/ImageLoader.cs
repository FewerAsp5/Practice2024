using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTools
{
    public class ImageLoader
    {
        private readonly PictureBox pictureBox;
        private readonly Label label;
        public ImageLoader(PictureBox image, Label altText)
        { 
            pictureBox = image;
            label = altText;
        }

        public void LoadImage(string path)
        {
            try
            {
                pictureBox.Image = Image.FromFile(path);
                pictureBox.Visible = true;
                label.Visible = false;
            }
            catch
            {
                ResetImage();
                label.Text = string.IsNullOrWhiteSpace(path)
                    ? "Файл не указан"
                    : $"Не удалось загрузить изображение из файла '{path}'";
            }
        }

        public void ResetImage()
        {
            pictureBox.Visible = false;
            label.Visible = true;
            label.Width = pictureBox.Width;
            label.Height = pictureBox.Height;
            label.Text = "";
        }
    }
}
