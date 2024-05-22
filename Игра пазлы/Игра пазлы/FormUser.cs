using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
                pictureBoxButtonThreeStripes.Height / 2,
                pictureBoxButtonThreeStripes.Width,
                pictureBoxButtonThreeStripes.Height / 2
            );
            graphics2.DrawLine
            (
                new Pen(Color.Black, 2),
                0,
                4,
                pictureBoxButtonThreeStripes.Width,
                4
            );
            graphics2.DrawLine
            (
                new Pen(Color.Black, 2),
                0,
                pictureBoxButtonThreeStripes.Height - 4,
                pictureBoxButtonThreeStripes.Width,
                pictureBoxButtonThreeStripes.Height - 4
            );

            pictureBoxButtonThreeStripes.Image = bmp;
            pictureBoxButtonThreeStripes.Refresh();
        }

        private void PlacingControlsOnThePanel()
        {
            string[] imageFiles = Directory.GetFiles(@"C:\Users\Дима\Desktop\картинки");

            const int pictureBoxWidth = 300;
            const int pictureBoxHeight = 250;
            const int pictureBoxMargin = 10;
            int pictureBoxXStart = (this.Width - this.Width / (pictureBoxWidth + pictureBoxMargin) * (pictureBoxWidth + pictureBoxMargin)) / 2;

            int x = pictureBoxXStart;
            int y = pictureBoxMargin;

            foreach (string imageFile in imageFiles)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imageFile);
                pictureBox.Location = new Point(x, y);
                pictureBox.Click += (s, ev) => PictureBoxClick(s);
                pictureBox.Name = Path.GetFileName(imageFile);

                panel1.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = Path.GetFileName(imageFile);
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(pictureBoxWidth, 50);
                label.Location = new Point(x, y + pictureBoxHeight);
                panel1.Controls.Add(label);

                x += pictureBoxWidth + pictureBoxMargin;
                if (x + pictureBoxWidth >= this.Width)
                {
                    x = pictureBoxXStart;
                    y += pictureBoxHeight + pictureBoxMargin + 50;
                }
                // Если PictureBox выходит за пределы формы, добавляем прокрутку
                if (y + pictureBoxHeight > this.ClientSize.Height)
                    panel1.AutoScroll = true;
            }
        }

        private void PictureBoxClick(object sender)
        {
            // При клике на PictureBox скрываем все PictureBox
            foreach (Control control in panel1.Controls)
            {
                if (control != (Control)sender)
                    control.Visible = false; ;
            }

            PictureBox pictureBox = (PictureBox)sender;
            Point proshliaPLocation = pictureBox.Location;
            Size proshliaPSize = pictureBox.Size;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(panel1.Width, panel1.Height);

            Label label = new Label();
            panel1.Controls.Add(label);
            label.Text = pictureBox.Name;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(panel1.Width, 50);
            label.Location = new Point(0, 0);
            label.BackColor = Color.Transparent;
            label.Parent = pictureBox;
            label.BringToFront();
            label.Font = new Font("Segoe Script", 19);

            Button buttonExit = new Button();
            Button buttonGame = new Button();
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonGame);
            buttonExit.Text = "Назад";
            buttonExit.Size = new Size(100, 50);
            buttonExit.Location = new Point(panel1.Width - 10 - buttonExit.Width, panel1.Height - 10 - buttonExit.Height);
            buttonExit.Parent = pictureBox;
            buttonExit.BringToFront();
            buttonExit.Click += (s, e) =>
            {
                panel1.Controls.Remove(buttonExit);
                panel1.Controls.Remove(buttonGame);
                panel1.Controls.Remove(label);
                pictureBox.Size = proshliaPSize;
                pictureBox.Location = proshliaPLocation;
                foreach (Control control in panel1.Controls)
                    control.Visible = true;
            };

            buttonGame.Text = "Играть";
            buttonGame.Size = new Size(100, 50);
            buttonGame.Location = new Point(10, panel1.Height - 10 - buttonGame.Height);
            buttonGame.Parent = pictureBox;
            buttonGame.BringToFront();
            buttonGame.Click += (s, e) =>
            {
                Button button4x4 = new Button();
                Button button8x8 = new Button();
                Button button16x16 = new Button();
                panel1.Controls.Add(button4x4);
                panel1.Controls.Add(button8x8);
                panel1.Controls.Add(button16x16);
                button4x4.Text = "4 на 4";
                button8x8.Text = "8 на 8";
                button16x16.Text = "16 на 16";
                button4x4.Size = new Size(100, 50);
                button8x8.Size = new Size(100, 50);
                button16x16.Size = new Size(100, 50);
                button4x4.Location = new Point(10, panel1.Height - 10 - button4x4.Height);
                button8x8.Location = new Point(10 + button4x4.Width + 10, panel1.Height - 10 - button8x8.Height);
                button16x16.Location = new Point(10 + button4x4.Width + 10 + button8x8.Width + 10, panel1.Height - 10 - button16x16.Height);
                button4x4.Parent = pictureBox;
                button8x8.Parent = pictureBox;
                button16x16.Parent = pictureBox;
                button4x4.BringToFront();
                button8x8.BringToFront();
                button16x16.BringToFront();
                
                button4x4.Click += (s1, e1) => 
                {
                    panel1.Controls.Remove(buttonGame);
                    panel1.Controls.Remove(buttonExit);
                    panel1.Controls.Remove(label);
                    panel1.Controls.Remove(buttonGame); 
                    button16x16.Visible=false;
                    button4x4.Visible=false;
                    button8x8.Visible=false;
                    pictureBox.Visible=false;
                    
                    Bitmap bitmap = BitmapResizer.Resize(pictureBox.Image, pictureBox.Width, pictureBox.Height);
                    ArrayPiecePuzzle array = new PuzzleGeneratorRandomLocation().Create(6, 6, bitmap);
                    new AddMovementOfPuzzlePieces( CreatePictureBoxForFullControl.Create(panel1),array);
                    
                    //panel1.Visible=false;
                    //Puzzle puzzle = new Puzzle(panel1,pictureBox.Image,pictureBox.Width,pictureBox.Height,4,4);
                    //Click(); 
                };
                //button8x8.Click += (s1, e1) => { rows = 8;columns = 8; panel1.Controls.Remove(buttonGame); Click(); };
                //button16x16.Click += (s1, e1) => { rows = 16; columns = 16; panel1.Controls.Remove(buttonGame); Click(); };


            };
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

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

        private void pictureBoxButtonThreeStripes_Click(object sender, EventArgs e)
        {
            //открываем панель
        }
    }
}
