using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();

            controlsRegistration=new List<Control> ();
            controlsEntrance=new List<Control> ();

            foreach(Control ctl in this.Controls)
            {
                if (ctl.Name.Contains("Registration") && !ctl.Name.Contains("Switch"))
                {
                    controlsRegistration.Add(ctl);
                }

                if (ctl.Name.Contains("Entrance") && !ctl.Name.Contains("Switch"))
                {
                    controlsEntrance.Add(ctl);
                }
            }
        }

        List<Control> controlsEntrance;
        List<Control> controlsRegistration;

        private void underlineForTextBox(){
            Graphics underlineForTextBox = this.CreateGraphics();

            List<Control> textBoxBuf;

            if (buttonSwitchEntrance.BackColor == Color.FromArgb(64, 64, 64))
                textBoxBuf = controlsEntrance;
            else
                textBoxBuf = controlsRegistration;

            underlineForTextBox.Clear(Color.FromArgb(64, 64, 64));

            foreach (Control cnt in textBoxBuf)
            {
                if (cnt.Name.Contains("textBox"))
                {
                    underlineForTextBox.DrawLine(new Pen(Color.Green),
                        cnt.Location.X,
                        cnt.Location.Y + cnt.Height + 1,
                        cnt.Location.X + cnt.Width,
                        cnt.Location.Y + cnt.Height + 1);
                }
            }
        }

        private void FormAuthorization_Paint(object sender, PaintEventArgs e)
        {
            underlineForTextBox();
        }

        private void buttonEntrance_Click(object sender, System.EventArgs e)
        {

        }

        private void drawningElements(List<Control> control,bool showOrHide)
        {
            foreach (Control cnt in control)
            {
                cnt.Visible = showOrHide;
                cnt.Enabled = showOrHide;
            }
        }
        private void buttonSwitchEntrance_Click(object sender, System.EventArgs e)
        {
            buttonSwitchEntrance.BackColor = Color.FromArgb(64, 64, 64);
            buttonSwitchRegistration.BackColor = Color.Gray;

            this.Height = 176;

            drawningElements(controlsRegistration, false);

            drawningElements(controlsEntrance, true);

            this.Refresh();
        }

        private void buttonSwitchRegistration_Click(object sender, System.EventArgs e)
        {
            buttonSwitchRegistration.BackColor = Color.FromArgb(64,64,64);
            buttonSwitchEntrance.BackColor = Color.Gray;

            this.Height = 231;

            drawningElements(controlsEntrance, false);

            drawningElements(controlsRegistration, true);

            this.Refresh();
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(
                (number<65 || number>90) && //A-Z
                (number < 97 || number > 122) && //a-z
                (number < 48 || number > 57) && //0-1
                (number != 95) && //_
                (number != 8) //стиреть

           )
                e.Handled = true;
        }
    }
}
