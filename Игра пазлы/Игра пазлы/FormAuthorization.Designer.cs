using System.Drawing;

namespace Игра_пазлы
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxEntranceLogin = new System.Windows.Forms.TextBox();
            this.labelEntranceLogin = new System.Windows.Forms.Label();
            this.textBoxEntrancePassword = new System.Windows.Forms.TextBox();
            this.labelEntrancePassword = new System.Windows.Forms.Label();
            this.buttonEntrance = new System.Windows.Forms.Button();
            this.buttonSwitchEntrance = new System.Windows.Forms.Button();
            this.buttonSwitchRegistration = new System.Windows.Forms.Button();
            this.textBoxRegistrationName = new System.Windows.Forms.TextBox();
            this.labelRegistrationName = new System.Windows.Forms.Label();
            this.textBoxRegistrationSurname = new System.Windows.Forms.TextBox();
            this.labelRegistrationSurname = new System.Windows.Forms.Label();
            this.textBoxRegistrationLogin = new System.Windows.Forms.TextBox();
            this.labelRegistrationLogin = new System.Windows.Forms.Label();
            this.textBoxRegistrationPassword = new System.Windows.Forms.TextBox();
            this.labelRegistrationPassword = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.toolTipRegistrationLogin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRegistrationPassword = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxEntranceLogin
            // 
            this.textBoxEntranceLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEntranceLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEntranceLogin.ForeColor = System.Drawing.Color.Green;
            this.textBoxEntranceLogin.Location = new System.Drawing.Point(149, 47);
            this.textBoxEntranceLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEntranceLogin.MaxLength = 10;
            this.textBoxEntranceLogin.Name = "textBoxEntranceLogin";
            this.textBoxEntranceLogin.Size = new System.Drawing.Size(100, 15);
            this.textBoxEntranceLogin.TabIndex = 0;
            this.textBoxEntranceLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxEntranceLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelEntranceLogin
            // 
            this.labelEntranceLogin.AutoSize = true;
            this.labelEntranceLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntranceLogin.ForeColor = System.Drawing.Color.Lime;
            this.labelEntranceLogin.Location = new System.Drawing.Point(69, 39);
            this.labelEntranceLogin.Name = "labelEntranceLogin";
            this.labelEntranceLogin.Size = new System.Drawing.Size(74, 28);
            this.labelEntranceLogin.TabIndex = 40;
            this.labelEntranceLogin.Text = "Логин";
            // 
            // textBoxEntrancePassword
            // 
            this.textBoxEntrancePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEntrancePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEntrancePassword.ForeColor = System.Drawing.Color.Green;
            this.textBoxEntrancePassword.Location = new System.Drawing.Point(149, 82);
            this.textBoxEntrancePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEntrancePassword.MaxLength = 12;
            this.textBoxEntrancePassword.Name = "textBoxEntrancePassword";
            this.textBoxEntrancePassword.Size = new System.Drawing.Size(100, 15);
            this.textBoxEntrancePassword.TabIndex = 1;
            this.textBoxEntrancePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxEntrancePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // labelEntrancePassword
            // 
            this.labelEntrancePassword.AutoSize = true;
            this.labelEntrancePassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntrancePassword.ForeColor = System.Drawing.Color.Lime;
            this.labelEntrancePassword.Location = new System.Drawing.Point(52, 75);
            this.labelEntrancePassword.Name = "labelEntrancePassword";
            this.labelEntrancePassword.Size = new System.Drawing.Size(90, 28);
            this.labelEntrancePassword.TabIndex = 40;
            this.labelEntrancePassword.Text = "Пароль";
            // 
            // buttonEntrance
            // 
            this.buttonEntrance.Enabled = false;
            this.buttonEntrance.Location = new System.Drawing.Point(149, 121);
            this.buttonEntrance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrance.Name = "buttonEntrance";
            this.buttonEntrance.Size = new System.Drawing.Size(100, 23);
            this.buttonEntrance.TabIndex = 2;
            this.buttonEntrance.Text = "button1";
            this.buttonEntrance.UseVisualStyleBackColor = true;
            this.buttonEntrance.Click += new System.EventHandler(this.buttonEntrance_Click);
            // 
            // buttonSwitchEntrance
            // 
            this.buttonSwitchEntrance.FlatAppearance.BorderSize = 0;
            this.buttonSwitchEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchEntrance.ForeColor = System.Drawing.Color.Lime;
            this.buttonSwitchEntrance.Location = new System.Drawing.Point(0, 0);
            this.buttonSwitchEntrance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSwitchEntrance.Name = "buttonSwitchEntrance";
            this.buttonSwitchEntrance.Size = new System.Drawing.Size(200, 30);
            this.buttonSwitchEntrance.TabIndex = 40;
            this.buttonSwitchEntrance.Text = "Войти";
            this.buttonSwitchEntrance.UseVisualStyleBackColor = true;
            this.buttonSwitchEntrance.Click += new System.EventHandler(this.buttonSwitchEntrance_Click);
            // 
            // buttonSwitchRegistration
            // 
            this.buttonSwitchRegistration.BackColor = System.Drawing.Color.Gray;
            this.buttonSwitchRegistration.FlatAppearance.BorderSize = 0;
            this.buttonSwitchRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchRegistration.ForeColor = System.Drawing.Color.Lime;
            this.buttonSwitchRegistration.Location = new System.Drawing.Point(200, 0);
            this.buttonSwitchRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSwitchRegistration.Name = "buttonSwitchRegistration";
            this.buttonSwitchRegistration.Size = new System.Drawing.Size(200, 30);
            this.buttonSwitchRegistration.TabIndex = 40;
            this.buttonSwitchRegistration.Text = "Регистрация";
            this.buttonSwitchRegistration.UseVisualStyleBackColor = false;
            this.buttonSwitchRegistration.Click += new System.EventHandler(this.buttonSwitchRegistration_Click);
            // 
            // textBoxRegistrationName
            // 
            this.textBoxRegistrationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRegistrationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistrationName.ForeColor = System.Drawing.Color.Green;
            this.textBoxRegistrationName.Location = new System.Drawing.Point(149, 47);
            this.textBoxRegistrationName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegistrationName.MaxLength = 20;
            this.textBoxRegistrationName.Name = "textBoxRegistrationName";
            this.textBoxRegistrationName.Size = new System.Drawing.Size(100, 15);
            this.textBoxRegistrationName.TabIndex = 4;
            this.textBoxRegistrationName.Visible = false;
            this.textBoxRegistrationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxRegistrationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegistrationNameAndSurname_KeyPress);
            // 
            // labelRegistrationName
            // 
            this.labelRegistrationName.AutoSize = true;
            this.labelRegistrationName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationName.ForeColor = System.Drawing.Color.Lime;
            this.labelRegistrationName.Location = new System.Drawing.Point(87, 39);
            this.labelRegistrationName.Name = "labelRegistrationName";
            this.labelRegistrationName.Size = new System.Drawing.Size(57, 28);
            this.labelRegistrationName.TabIndex = 40;
            this.labelRegistrationName.Text = "Имя";
            this.labelRegistrationName.Visible = false;
            // 
            // textBoxRegistrationSurname
            // 
            this.textBoxRegistrationSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRegistrationSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistrationSurname.ForeColor = System.Drawing.Color.Green;
            this.textBoxRegistrationSurname.Location = new System.Drawing.Point(149, 82);
            this.textBoxRegistrationSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegistrationSurname.MaxLength = 20;
            this.textBoxRegistrationSurname.Name = "textBoxRegistrationSurname";
            this.textBoxRegistrationSurname.Size = new System.Drawing.Size(100, 15);
            this.textBoxRegistrationSurname.TabIndex = 5;
            this.textBoxRegistrationSurname.Visible = false;
            this.textBoxRegistrationSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxRegistrationSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegistrationNameAndSurname_KeyPress);
            // 
            // labelRegistrationSurname
            // 
            this.labelRegistrationSurname.AutoSize = true;
            this.labelRegistrationSurname.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationSurname.ForeColor = System.Drawing.Color.Lime;
            this.labelRegistrationSurname.Location = new System.Drawing.Point(32, 75);
            this.labelRegistrationSurname.Name = "labelRegistrationSurname";
            this.labelRegistrationSurname.Size = new System.Drawing.Size(110, 28);
            this.labelRegistrationSurname.TabIndex = 40;
            this.labelRegistrationSurname.Text = "Фамилия";
            this.labelRegistrationSurname.Visible = false;
            // 
            // textBoxRegistrationLogin
            // 
            this.textBoxRegistrationLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRegistrationLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistrationLogin.ForeColor = System.Drawing.Color.Green;
            this.textBoxRegistrationLogin.Location = new System.Drawing.Point(149, 117);
            this.textBoxRegistrationLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegistrationLogin.MaxLength = 10;
            this.textBoxRegistrationLogin.Name = "textBoxRegistrationLogin";
            this.textBoxRegistrationLogin.Size = new System.Drawing.Size(100, 15);
            this.textBoxRegistrationLogin.TabIndex = 6;
            this.textBoxRegistrationLogin.Visible = false;
            this.textBoxRegistrationLogin.TextChanged += new System.EventHandler(this.textBoxRegistrationLogin_TextChanged);
            this.textBoxRegistrationLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxRegistrationLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelRegistrationLogin
            // 
            this.labelRegistrationLogin.AutoSize = true;
            this.labelRegistrationLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationLogin.ForeColor = System.Drawing.Color.Lime;
            this.labelRegistrationLogin.Location = new System.Drawing.Point(69, 110);
            this.labelRegistrationLogin.Name = "labelRegistrationLogin";
            this.labelRegistrationLogin.Size = new System.Drawing.Size(74, 28);
            this.labelRegistrationLogin.TabIndex = 40;
            this.labelRegistrationLogin.Text = "Логин";
            this.labelRegistrationLogin.Visible = false;
            // 
            // textBoxRegistrationPassword
            // 
            this.textBoxRegistrationPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRegistrationPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistrationPassword.ForeColor = System.Drawing.Color.Green;
            this.textBoxRegistrationPassword.Location = new System.Drawing.Point(149, 153);
            this.textBoxRegistrationPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegistrationPassword.MaxLength = 12;
            this.textBoxRegistrationPassword.Name = "textBoxRegistrationPassword";
            this.textBoxRegistrationPassword.Size = new System.Drawing.Size(100, 15);
            this.textBoxRegistrationPassword.TabIndex = 7;
            this.textBoxRegistrationPassword.Visible = false;
            this.textBoxRegistrationPassword.TextChanged += new System.EventHandler(this.textBoxRegistrationPassword_TextChanged);
            this.textBoxRegistrationPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxRegistrationPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // labelRegistrationPassword
            // 
            this.labelRegistrationPassword.AutoSize = true;
            this.labelRegistrationPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationPassword.ForeColor = System.Drawing.Color.Lime;
            this.labelRegistrationPassword.Location = new System.Drawing.Point(52, 145);
            this.labelRegistrationPassword.Name = "labelRegistrationPassword";
            this.labelRegistrationPassword.Size = new System.Drawing.Size(90, 28);
            this.labelRegistrationPassword.TabIndex = 40;
            this.labelRegistrationPassword.Text = "Пароль";
            this.labelRegistrationPassword.Visible = false;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Enabled = false;
            this.buttonRegistration.Location = new System.Drawing.Point(149, 191);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(100, 23);
            this.buttonRegistration.TabIndex = 8;
            this.buttonRegistration.Text = "button1";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Visible = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(381, 169);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelRegistrationPassword);
            this.Controls.Add(this.textBoxRegistrationPassword);
            this.Controls.Add(this.labelRegistrationLogin);
            this.Controls.Add(this.textBoxRegistrationLogin);
            this.Controls.Add(this.labelRegistrationSurname);
            this.Controls.Add(this.textBoxRegistrationSurname);
            this.Controls.Add(this.labelRegistrationName);
            this.Controls.Add(this.textBoxRegistrationName);
            this.Controls.Add(this.buttonSwitchRegistration);
            this.Controls.Add(this.buttonSwitchEntrance);
            this.Controls.Add(this.buttonEntrance);
            this.Controls.Add(this.labelEntrancePassword);
            this.Controls.Add(this.textBoxEntrancePassword);
            this.Controls.Add(this.labelEntranceLogin);
            this.Controls.Add(this.textBoxEntranceLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAuthorization_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEntranceLogin;
        private System.Windows.Forms.Label labelEntranceLogin;
        private System.Windows.Forms.TextBox textBoxEntrancePassword;
        private System.Windows.Forms.Label labelEntrancePassword;
        private System.Windows.Forms.Button buttonEntrance;
        private System.Windows.Forms.Button buttonSwitchEntrance;
        private System.Windows.Forms.Button buttonSwitchRegistration;
        private System.Windows.Forms.TextBox textBoxRegistrationName;
        private System.Windows.Forms.Label labelRegistrationName;
        private System.Windows.Forms.TextBox textBoxRegistrationSurname;
        private System.Windows.Forms.Label labelRegistrationSurname;
        private System.Windows.Forms.TextBox textBoxRegistrationLogin;
        private System.Windows.Forms.Label labelRegistrationLogin;
        private System.Windows.Forms.TextBox textBoxRegistrationPassword;
        private System.Windows.Forms.Label labelRegistrationPassword;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.ToolTip toolTipRegistrationLogin;
        private System.Windows.Forms.ToolTip toolTipRegistrationPassword;
    }
}

