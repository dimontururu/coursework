using System.Drawing;
using System.Windows.Forms;
using System;
using Игра_пазлы.Puzzle;

namespace Игра_пазлы.PicturesFormUser.PicturesOnTheMainScreenClick
{
    internal class PicturesOnTheMainScreenClicked
    {
        PicturesOnTheMainScreen[] array;
        Control formOrPanel;
        Control[] addedControls = new Control[8]; 
        public PicturesOnTheMainScreenClicked(PicturesOnTheMainScreen[] array, Control formOrPanel)
        {
            this.array = array;
            this.formOrPanel = formOrPanel;
        }
        public void PictureBoxClick(object sender, EventArgs e2)
        {
            // При клике на PictureBox скрываем все PictureBox
            VisibalPicturesOnTheMainScreen.Hide(array);

            PictureBox pictureBox = (PictureBox)sender;
            ADDPictureBox(pictureBox.Image,pictureBox.Name);
            ADDLabel();
            ADDExitButton();
            ADDButtonGame();
            ADDButtonStatistics();
        }

        private void ADDPictureBox(Image image,string name)
        {
            PictureBox pictureBox = CreatePictureBoxForFullControl.Create(formOrPanel);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Name = name;
            addedControls[0]=pictureBox;
            formOrPanel.Controls.Add(pictureBox);
        }

        private void ADDExitButton()
        {
            PictureBox buttonExit = CreateExitButton.Create();
            addedControls[1] = buttonExit;
            formOrPanel.Controls.Add(buttonExit);
            buttonExit.Size = new Size(100, 50);
            buttonExit.Location = new Point();
            buttonExit.Parent = addedControls[0];
            buttonExit.BringToFront();
            buttonExit.Click += (s, e) =>
            {
                clinAddedControls();
                VisibalPicturesOnTheMainScreen.Show(array);
            };
        }

        private void ADDLabel()
        {
            Label label = new Label();
            addedControls[2] = label;
            formOrPanel.Controls.Add(label);
            label.Text = ((PictureBox)addedControls[0]).Name;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(formOrPanel.Width, 50);
            label.Location = new Point(0, 0);
            label.BackColor = Color.Transparent;
            label.Parent = addedControls[0];
            label.BringToFront();
            label.Font = new Font("Segoe Script", 19);
        }

        private void ADDButtonGame()
        {
            PictureBox buttonGame = CreateGameButton.Create();
            formOrPanel.Controls.Add(buttonGame);
            addedControls[3] = buttonGame;
            buttonGame.Size = new Size(100, 50);
            buttonGame.Location = new Point(10, formOrPanel.Height - 10 - buttonGame.Height);
            buttonGame.Parent = addedControls[0];
            buttonGame.BringToFront();
            buttonGame.Click += (s, e) =>
            {
                Button button4x4 = new Button();
                Button button8x8 = new Button();
                Button button16x16 = new Button();
                addedControls[4] = button4x4;
                addedControls[5] = button8x8;
                addedControls[6] = button16x16;
                formOrPanel.Controls.Add(button4x4);
                formOrPanel.Controls.Add(button8x8);
                formOrPanel.Controls.Add(button16x16);
                button4x4.Text = "4x4";
                button8x8.Text = "5x5";
                button16x16.Text = "6x6";

                button4x4.Font = new Font(button4x4.Font.FontFamily,19, button4x4.Font.Style);
                button8x8.Font = new Font(button4x4.Font.FontFamily, 19, button4x4.Font.Style);
                button16x16.Font = new Font(button4x4.Font.FontFamily, 19, button4x4.Font.Style);

                button4x4.Size = new Size(100, 50);
                button8x8.Size = new Size(100, 50);
                button16x16.Size = new Size(100, 50);
                button4x4.Parent = addedControls[0];
                button8x8.Parent = addedControls[0];
                button16x16.Parent = addedControls[0];
                button4x4.BringToFront();
                button8x8.BringToFront();
                button16x16.BringToFront();

                button4x4.Location = new Point(10, formOrPanel.Height - 10 - button4x4.Height);
                button8x8.Location = new Point(10 + button4x4.Width + 10, formOrPanel.Height - 10 - button8x8.Height);
                button16x16.Location = new Point(10 + button4x4.Width + 10 + button8x8.Width + 10, formOrPanel.Height - 10 - button16x16.Height);

                button4x4.BackColor = Color.FromArgb(255, 0, 255, 0);
                button8x8.BackColor = Color.FromArgb(255, 0, 255, 0);
                button16x16.BackColor = Color.FromArgb(255, 0, 255, 0);
                button4x4.Click += click;
                button8x8.Click += click;
                button16x16.Click += click;

            };
        }

        private void ADDButtonStatistics() 
        {
            Button ButtonStatistics = new Button();
            formOrPanel.Controls.Add(ButtonStatistics);
            addedControls[7] = ButtonStatistics;
            ButtonStatistics.Size = new Size(100, 50);
            ButtonStatistics.Location = new Point(formOrPanel.Width - ButtonStatistics.Width-10, formOrPanel.Height - ButtonStatistics.Height-10);
            ButtonStatistics.Parent = addedControls[0];
            ButtonStatistics.BringToFront();
            ButtonStatistics.BackColor = Color.FromArgb(255, 0, 255, 0);
            ButtonStatistics.Font=new Font(ButtonStatistics.Font.FontFamily, 10, ButtonStatistics.Font.Style);
            ButtonStatistics.Text = "Статистика";
            ButtonStatistics.Click += (s, e) => { 
                statistics statistics = new statistics(addedControls[2].Text);
                DataGridView dataGridView = statistics.dataGridView;
                dataGridView.Size= new Size(formOrPanel.Width, formOrPanel.Height);
                formOrPanel.Controls.Add(dataGridView);
                dataGridView.BringToFront();

                PictureBox buttonExit = CreateExitButton.Create();
                buttonExit.Location = new Point(10, dataGridView.Height -buttonExit.Height - 10);
                formOrPanel.Controls.Add(buttonExit);
                buttonExit.BringToFront();
                buttonExit.Click += (s2, e2) => { formOrPanel.Controls.Remove(buttonExit); formOrPanel.Controls.Remove(dataGridView); };
            };
        }

        private void click(object sender, EventArgs e)
        {
            clinAddedControls();
            int x=4, y=4;
            switch (((Button)sender).Text)
            {
                case "5x5":
                    x = 5;
                    y = 5;
                    break;
                case "6x6":
                    x = 6;
                    y = 6;
                    break;
            }
            Bitmap bitmap = BitmapResizer.Resize(((PictureBox)addedControls[0]).Image, addedControls[0].Width, addedControls[0].Height);
            ArrayPiecePuzzle array = new PuzzleGeneratorRandomLocation().Create(x, y, bitmap);
            Label time = new Label();
            formOrPanel.Controls.Add(time);
            Timer timer = new Timer(time);
            timer.start();
            PictureBox pictureBox = CreatePictureBoxForFullControl.Create(formOrPanel);
            time.Parent= pictureBox;
            time.BringToFront();
            pictureBox.MouseUp += (s1, e1) => { if (CheckVictoryPuzzle.check(array)) MessageBox.Show("победа"); };
            new AddMovementOfPuzzlePieces(pictureBox, array);

        }
        private void clinAddedControls()
        {
            foreach(Control control in addedControls)
                formOrPanel.Controls.Remove(control);
        }
    }
}
