namespace Игра_пазлы
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameGame = new System.Windows.Forms.Label();
            this.pictureBoxButtonThreeStripes = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonThreeStripes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameGame
            // 
            this.labelNameGame.AutoSize = true;
            this.labelNameGame.BackColor = System.Drawing.Color.Green;
            this.labelNameGame.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameGame.Location = new System.Drawing.Point(572, 39);
            this.labelNameGame.Name = "labelNameGame";
            this.labelNameGame.Size = new System.Drawing.Size(134, 55);
            this.labelNameGame.TabIndex = 0;
            this.labelNameGame.Text = "Пазлы";
            // 
            // pictureBoxButtonThreeStripes
            // 
            this.pictureBoxButtonThreeStripes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonThreeStripes.Location = new System.Drawing.Point(771, 68);
            this.pictureBoxButtonThreeStripes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxButtonThreeStripes.Name = "pictureBoxButtonThreeStripes";
            this.pictureBoxButtonThreeStripes.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxButtonThreeStripes.TabIndex = 1;
            this.pictureBoxButtonThreeStripes.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(432, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxButtonThreeStripes);
            this.Controls.Add(this.labelNameGame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormUser_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonThreeStripes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameGame;
        private System.Windows.Forms.PictureBox pictureBoxButtonThreeStripes;
        private System.Windows.Forms.Panel panel1;
    }
}