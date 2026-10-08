namespace Pr3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginL = new Label();
            pswdL = new Label();
            label3 = new Label();
            loginTB = new TextBox();
            pswdTB = new TextBox();
            enterBut = new Button();
            lookPswdL = new Label();
            wrongL = new Label();
            regL = new Label();
            enterL = new Label();
            SuspendLayout();
            // 
            // loginL
            // 
            loginL.AutoSize = true;
            loginL.Font = new Font("Segoe UI", 16F);
            loginL.Location = new Point(264, 212);
            loginL.Margin = new Padding(4, 0, 4, 0);
            loginL.Name = "loginL";
            loginL.Size = new Size(110, 45);
            loginL.TabIndex = 0;
            loginL.Text = "Логин";
            // 
            // pswdL
            // 
            pswdL.AutoSize = true;
            pswdL.Font = new Font("Segoe UI", 16F);
            pswdL.Location = new Point(264, 327);
            pswdL.Margin = new Padding(4, 0, 4, 0);
            pswdL.Name = "pswdL";
            pswdL.Size = new Size(130, 45);
            pswdL.TabIndex = 1;
            pswdL.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(521, 622);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 40);
            label3.TabIndex = 2;
            label3.Text = "Войти как гость";
            label3.Click += label3_Click;
            // 
            // loginTB
            // 
            loginTB.Font = new Font("Segoe UI", 16F);
            loginTB.Location = new Point(467, 207);
            loginTB.Margin = new Padding(4, 5, 4, 5);
            loginTB.Name = "loginTB";
            loginTB.Size = new Size(483, 50);
            loginTB.TabIndex = 3;
            // 
            // pswdTB
            // 
            pswdTB.Font = new Font("Segoe UI", 16F);
            pswdTB.Location = new Point(467, 317);
            pswdTB.Margin = new Padding(4, 5, 4, 5);
            pswdTB.Name = "pswdTB";
            pswdTB.PasswordChar = '*';
            pswdTB.Size = new Size(483, 50);
            pswdTB.TabIndex = 4;
            // 
            // enterBut
            // 
            enterBut.BackColor = Color.YellowGreen;
            enterBut.Font = new Font("Segoe UI", 16F);
            enterBut.Location = new Point(461, 486);
            enterBut.Margin = new Padding(4, 5, 4, 5);
            enterBut.Name = "enterBut";
            enterBut.Size = new Size(362, 97);
            enterBut.TabIndex = 5;
            enterBut.Text = "Войти";
            enterBut.UseVisualStyleBackColor = false;
            enterBut.Click += enterBut_Click;
            // 
            // lookPswdL
            // 
            lookPswdL.AutoSize = true;
            lookPswdL.BackColor = SystemColors.Control;
            lookPswdL.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            lookPswdL.ForeColor = Color.DarkGreen;
            lookPswdL.Location = new Point(467, 382);
            lookPswdL.Margin = new Padding(4, 0, 4, 0);
            lookPswdL.Name = "lookPswdL";
            lookPswdL.Size = new Size(210, 32);
            lookPswdL.TabIndex = 6;
            lookPswdL.Text = "Показать пароль";
            lookPswdL.Click += lookPswdL_Click;
            // 
            // wrongL
            // 
            wrongL.AutoSize = true;
            wrongL.Font = new Font("Segoe UI", 13F);
            wrongL.ForeColor = Color.Brown;
            wrongL.Location = new Point(461, 142);
            wrongL.Name = "wrongL";
            wrongL.Size = new Size(22, 36);
            wrongL.TabIndex = 7;
            wrongL.Text = " ";
            // 
            // regL
            // 
            regL.AutoSize = true;
            regL.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            regL.ForeColor = Color.DarkGreen;
            regL.Location = new Point(21, 20);
            regL.Name = "regL";
            regL.Size = new Size(164, 36);
            regL.TabIndex = 8;
            regL.Text = "Регистрация";
            regL.Click += regL_Click;
            // 
            // enterL
            // 
            enterL.AutoSize = true;
            enterL.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point, 204);
            enterL.ForeColor = Color.DarkGreen;
            enterL.Location = new Point(21, 71);
            enterL.Name = "enterL";
            enterL.Size = new Size(86, 36);
            enterL.TabIndex = 9;
            enterL.Text = "Войти";
            enterL.Click += enterL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 798);
            Controls.Add(enterL);
            Controls.Add(regL);
            Controls.Add(wrongL);
            Controls.Add(lookPswdL);
            Controls.Add(enterBut);
            Controls.Add(pswdTB);
            Controls.Add(loginTB);
            Controls.Add(label3);
            Controls.Add(pswdL);
            Controls.Add(loginL);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Войти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginL;
        private Label pswdL;
        private Label label3;
        private TextBox loginTB;
        private TextBox pswdTB;
        private Button enterBut;
        private Label lookPswdL;
        private Label wrongL;
        private Label regL;
        private Label enterL;
    }
}
