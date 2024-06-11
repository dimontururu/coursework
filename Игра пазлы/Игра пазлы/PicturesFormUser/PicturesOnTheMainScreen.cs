using System;
using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class PicturesOnTheMainScreen
    {
        public PictureBox pictureBox;
        public Label label;

        public PicturesOnTheMainScreen(Point pictureBoxLocation, Size pictureBoxSize,string pictureBoxName, Image pictureBoxImage,EventHandler pictureBoxClick=null) 
        {
            if (pictureBoxLocation == null || pictureBoxSize == null || pictureBoxImage == null)
                throw new System.Exception();

            pictureBox = new PictureBox();
            pictureBox.Size = pictureBoxSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = pictureBoxImage;
            pictureBox.Location = pictureBoxLocation;
            pictureBox.Click +=pictureBoxClick;
            pictureBox.Name = pictureBoxName;

            //panel1.Controls.Add(pictureBox);

            label = new Label();
            label.Text = pictureBoxName;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(pictureBoxSize.Width, 50);
            label.Location = new Point(pictureBoxLocation.X, pictureBoxLocation.Y + pictureBoxSize.Height);
            //panel1.Controls.Add(label);
        }
    }
}
