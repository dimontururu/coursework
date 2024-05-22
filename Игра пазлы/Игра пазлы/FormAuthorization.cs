using BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Игра_пазлы
{
    public partial class FormAuthorization : Form
    {
        List<Control> controlsEntrance;
        List<Control> controlsRegistration;

        Color textBoxRegistrationLoginUnderLineColor = Color.Green;
        Color textBoxRegistrationPasswordUnderLineColor = Color.Green;

        bd BD=new bd();

        bool passwordIsCorrect;
        bool loginIsCorrect;

        public FormAuthorization()
        {
            InitializeComponent();

            controlsRegistration=new List<Control> ();
            controlsEntrance=new List<Control> ();

            foreach (Control ctl in this.Controls)
            {
                if (ctl.Name.Contains("Registration") && !ctl.Name.Contains("Switch"))
                    controlsRegistration.Add(ctl);

                if (ctl.Name.Contains("Entrance") && !ctl.Name.Contains("Switch"))
                    controlsEntrance.Add(ctl);
            }

            textBoxRegistrationName.TextChanged += (sender, e) => { CheckTextBoxesRegistration(); };
            textBoxRegistrationSurname.TextChanged += (sender, e) => { CheckTextBoxesRegistration(); };
            textBoxRegistrationLogin.TextChanged += (sender, e) => { CheckTextBoxesRegistration(); };
            textBoxRegistrationPassword.TextChanged += (sender, e) => { CheckTextBoxesRegistration(); };

            textBoxEntranceLogin.TextChanged += (sender, e) => { CheckTextBoxesEntrance(); };
            textBoxEntrancePassword.TextChanged += (sender, e) => { CheckTextBoxesEntrance(); };

            //buttonEntrance.FlatStyle = FlatStyle.Flat;
        }

        private void underlineForTextBox(){
            Graphics underlineForTextBox = this.CreateGraphics();

            List<Control> textBoxBuf;

            if (buttonSwitchEntrance.BackColor == Color.FromArgb(64, 64, 64))
                textBoxBuf = controlsEntrance;
            else
                textBoxBuf = controlsRegistration;

            underlineForTextBox.Clear(Color.FromArgb(64, 64, 64));

            Pen pen;
            foreach (Control cnt in textBoxBuf)
            {
                if (cnt.Name.Contains("textBox"))
                {
                    pen = new Pen(Color.Green);

                    if (cnt.Name.Contains("RegistrationLogin"))
                        pen = new Pen(textBoxRegistrationLoginUnderLineColor);

                    if (cnt.Name.Contains("RegistrationPassword"))
                        pen = new Pen(textBoxRegistrationPasswordUnderLineColor);

                    underlineForTextBox.DrawLine
                    (
                        pen,
                        cnt.Location.X,
                        cnt.Location.Y + cnt.Height + 1,
                        cnt.Location.X + cnt.Width,
                        cnt.Location.Y + cnt.Height + 1
                    );
                }
            }
        }

        private void FormAuthorization_Paint(object sender, PaintEventArgs e)
        {
            underlineForTextBox();
        }

        private void buttonEntrance_Click(object sender, System.EventArgs e)
        {
            var login = textBoxEntranceLogin.Text;
            var password = textBoxEntrancePassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from Users where login ='{login}' and password ='{password}'";

            SqlCommand sqlCommand = new SqlCommand(query, BD.getbd());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                char userType = Convert.ToChar(table.Rows[0]["User_type"]);
                this.Hide();
                if (userType == 'A')
                {
                    MessageBox.Show("админ");
                    //Form FormAdmin = new FormAdmin();
                    //FormAdmin.Show();
                }
                if (userType == 'P')
                {
                    Form form = new FormUser();
                    form.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует");
            }
        }

        private void drawningElements(List<Control> control,bool showOrHide)
        {
            foreach (Control cnt in control)
                cnt.Visible = showOrHide;
        }
        private void buttonSwitchEntrance_Click(object sender, System.EventArgs e)
        {
            buttonSwitchEntrance.BackColor = Color.FromArgb(64, 64, 64);
            buttonSwitchRegistration.BackColor = Color.Gray;

            this.Height = 176;

            drawningElements(controlsRegistration, false);

            toolTipRegistrationPassword?.Hide(textBoxRegistrationPassword);
            toolTipRegistrationLogin?.Hide(textBoxRegistrationLogin);

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

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (
                (number < 65 || number > 90) && //A-Z
                (number < 97 || number > 122) && //a-z
                (number < 48 || number > 57) && //0-1
                (number != 8) //стиреть

           )
                e.Handled = true;
        }

        private void textBoxRegistrationNameAndSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (
                (number < 'а' || number > 'я') && //А-Я
                (number < 'А' || number > 'Я') && //а-я
                (number != 8) //стиреть

           )
                e.Handled = true;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            Control control = (Control)sender;

            if (e.KeyCode == Keys.Enter)
            {
                if (control.Name.Contains("Registration"))
                {
                    foreach (Control cnt in controlsRegistration)
                        if (control.TabIndex + 1 == cnt.TabIndex)
                        {
                            cnt.Focus();
                            break;
                        }
                }
                else
                {

                    foreach (Control cnt in controlsEntrance)
                        if (control.TabIndex + 1 == cnt.TabIndex)
                        {
                            cnt.Focus();
                            break;
                        }
                }
            }
        }

        private void textBoxRegistrationLogin_TextChanged(object sender, System.EventArgs e)
        {
            var login = textBoxRegistrationLogin.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select * from Users where Login ='{login}'";

            SqlCommand sqlCommand = new SqlCommand(query, BD.getbd());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                if (textBoxRegistrationLoginUnderLineColor == Color.Green)
                {
                    textBoxRegistrationLoginUnderLineColor = Color.Red;
                    this.Refresh();

                    toolTipRegistrationLogin.Show
                        (
                            "Такой пользователь уже существует",
                            textBoxRegistrationLogin,
                            textBoxRegistrationLogin.Size.Width,
                            -textBoxRegistrationLogin.Size.Height
                        );
                }
                loginIsCorrect = false;
            }
            else
            {
                if (textBoxRegistrationLoginUnderLineColor == Color.Red)
                {
                    textBoxRegistrationLoginUnderLineColor = Color.Green;
                    this.Refresh();

                    toolTipRegistrationLogin.Hide(textBoxRegistrationLogin);

                }
                loginIsCorrect = true;
            }
        }

        private void textBoxRegistrationPassword_TextChanged(object sender, EventArgs e)
        {
            bool capitalLetter=false;
            bool smallCaseLetter = false;
            bool presenceOfNumbers = false;

            for ( int i = 0;i<textBoxRegistrationPassword.Text.Length;i++ ) 
            {
                if (textBoxRegistrationPassword.Text[i]>='A' && textBoxRegistrationPassword.Text[i] <= 'Z')
                    capitalLetter = true;

                if (textBoxRegistrationPassword.Text[i] >= 'a' && textBoxRegistrationPassword.Text[i] <= 'z')
                    smallCaseLetter = true;

                if (textBoxRegistrationPassword.Text[i] >= '0' && textBoxRegistrationPassword.Text[i] <= '9')
                    presenceOfNumbers = true;
            }

            if (capitalLetter && smallCaseLetter && presenceOfNumbers && textBoxRegistrationPassword.Text.Length>7) 
            {
                if (textBoxRegistrationPasswordUnderLineColor == Color.Red)
                {
                    toolTipRegistrationPassword.Hide(textBoxRegistrationPassword);
                    textBoxRegistrationPasswordUnderLineColor = Color.Green;
                    passwordIsCorrect = true;
                    this.Refresh();
                }
            }
            else
            {
                if (textBoxRegistrationPasswordUnderLineColor == Color.Green)
                {
                    toolTipRegistrationPassword.Show
                    (
                        "Пароль должен содержать не меньше 8 символов\nбуквы большого и малого регистра и цифры",
                        textBoxRegistrationPassword,
                        textBoxRegistrationPassword.Size.Width,
                        -textBoxRegistrationPassword.Size.Height
                    );
                    passwordIsCorrect = false;
                    textBoxRegistrationPasswordUnderLineColor = Color.Red;
                    this.Refresh();
                }
            }
        }

        void CheckTextBoxesRegistration()
        {
            if (!string.IsNullOrEmpty(textBoxRegistrationName.Text) &&
                !string.IsNullOrEmpty(textBoxRegistrationSurname.Text) &&
                loginIsCorrect &&
                passwordIsCorrect)
            {
                buttonRegistration.Enabled = true;
            }
            else
            {
                buttonRegistration.Enabled = false; 
            }
        }

        void CheckTextBoxesEntrance()
        {
            if (!string.IsNullOrEmpty(textBoxEntranceLogin.Text) &&
                !string.IsNullOrEmpty(textBoxEntrancePassword.Text)
                )
            {
                buttonEntrance.Enabled = true;
            }
            else
            {
                buttonEntrance.Enabled = false;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            string query = $"insert into users(Login, Password, Name, Surname, User_type) values('{textBoxRegistrationLogin.Text}','{textBoxRegistrationPassword.Text}','{textBoxRegistrationName.Text}','{textBoxRegistrationSurname.Text}','P')";

            SqlCommand sqlCommand = new SqlCommand(query, BD.getbd());

            BD.openconected();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегистрировались");
                this.Hide();
                Form form = new FormUser();
                form.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка");
            BD.Closeconected();
        }
    }
}
