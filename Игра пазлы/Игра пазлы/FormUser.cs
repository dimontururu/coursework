using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Игра_пазлы.PicturesFormUser;

namespace Игра_пазлы
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void SetTheSizeOfTheElements()
        {
            this.pictureBoxButtonThreeStripes.Size = new Size
            (
                labelNameGame.Size.Height,
                labelNameGame.Size.Height
            );

            panel1.Size = new Size
            (
                this.Width - 20,
                this.Height - this.pictureBoxButtonThreeStripes.Size.Height - 20
            );
        }

        private void SetTheLocationOfTheElements()
        {
            this.pictureBoxButtonThreeStripes.Location = new Point
            (
                this.Width - this.pictureBoxButtonThreeStripes.Size.Width,
                0
            );

            panel1.Location = new Point
            (
                0 + 10,
                this.pictureBoxButtonThreeStripes.Size.Height + 10
            );

            labelNameGame.Location = new Point
            (
                this.Size.Width / 2 - labelNameGame.Size.Width / 2,
                0
            );
        }

        private void DrawOnThePictureBoxButtonThreeStripes()
        {
            Bitmap bmp = new Bitmap(pictureBoxButtonThreeStripes.Width, pictureBoxButtonThreeStripes.Height);
            Graphics graphics2 = Graphics.FromImage(bmp);

            graphics2.Clear(Color.Green);
            graphics2.DrawLine
            (
                new Pen(Color.Black, 2),
                0,
                0,
                pictureBoxButtonThreeStripes.Width,
                pictureBoxButtonThreeStripes.Height
            );
            graphics2.DrawLine
            (
                new Pen(Color.Black, 2),
                pictureBoxButtonThreeStripes.Width,
                0,
                0,
                pictureBoxButtonThreeStripes.Height
            );
            pictureBoxButtonThreeStripes.Image = bmp;
            pictureBoxButtonThreeStripes.Refresh();

            pictureBoxButtonThreeStripes.Click += (s, e) => { this.Close(); };
        }

        private void PlacingControlsOnThePanel()
        {
            GeneratiorPicturesOnTheMainScreen.Generator(panel1);
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            panel1.AutoScroll = true;
            SetTheSizeOfTheElements();

            SetTheLocationOfTheElements();

            DrawOnThePictureBoxButtonThreeStripes();

            PlacingControlsOnThePanel();
        }

        private void FormUser_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            graphics.FillRectangle
            (
                new SolidBrush(Color.Green),
                0,
                0,
                this.Width,
                labelNameGame.Location.Y + labelNameGame.Size.Height
            );

            graphics.FillRectangle
            (
                new SolidBrush(Color.Black),
                0,
                labelNameGame.Location.Y + labelNameGame.Size.Height,
                this.Width,
                this.Height
            );
        }
    }
}
