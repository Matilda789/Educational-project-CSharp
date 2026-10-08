namespace Pr3
{
    partial class Form2
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
            listBox = new ListBox();
            roleL = new Label();
            label1 = new Label();
            sortBut = new Button();
            addBut = new Button();
            deleteBut = new Button();
            label2 = new Label();
            newPosL = new Label();
            addPosTB = new TextBox();
            deleteAllBut = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 16F);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 45;
            listBox.Location = new Point(17, 77);
            listBox.Margin = new Padding(4, 5, 4, 5);
            listBox.Name = "listBox";
            listBox.Size = new Size(698, 679);
            listBox.TabIndex = 0;
            // 
            // roleL
            // 
            roleL.AutoSize = true;
            roleL.Font = new Font("Segoe UI", 14F);
            roleL.ForeColor = Color.DarkGreen;
            roleL.Location = new Point(207, 18);
            roleL.Margin = new Padding(4, 0, 4, 0);
            roleL.Name = "roleL";
            roleL.Size = new Size(84, 38);
            roleL.TabIndex = 1;
            roleL.Text = "Гость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(17, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 36);
            label1.TabIndex = 2;
            label1.Text = "Вы вошли как:";
            // 
            // sortBut
            // 
            sortBut.BackColor = Color.YellowGreen;
            sortBut.Font = new Font("Segoe UI", 14F);
            sortBut.Location = new Point(754, 77);
            sortBut.Margin = new Padding(4, 5, 4, 5);
            sortBut.Name = "sortBut";
            sortBut.Size = new Size(301, 82);
            sortBut.TabIndex = 3;
            sortBut.Text = "Сортировать";
            sortBut.UseVisualStyleBackColor = false;
            sortBut.Click += sortBut_Click;
            // 
            // addBut
            // 
            addBut.BackColor = Color.YellowGreen;
            addBut.Font = new Font("Segoe UI", 14F);
            addBut.Location = new Point(754, 361);
            addBut.Margin = new Padding(4, 5, 4, 5);
            addBut.Name = "addBut";
            addBut.Size = new Size(301, 82);
            addBut.TabIndex = 4;
            addBut.Text = "Добавить";
            addBut.UseVisualStyleBackColor = false;
            addBut.Click += addBut_Click;
            // 
            // deleteBut
            // 
            deleteBut.BackColor = Color.Silver;
            deleteBut.Font = new Font("Segoe UI", 14F);
            deleteBut.Location = new Point(754, 555);
            deleteBut.Margin = new Padding(4, 5, 4, 5);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(301, 82);
            deleteBut.TabIndex = 5;
            deleteBut.Text = "Удалить";
            deleteBut.UseVisualStyleBackColor = false;
            deleteBut.Click += deleteBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(980, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 6;
            label2.Text = "Выход";
            label2.Click += label2_Click;
            // 
            // newPosL
            // 
            newPosL.AutoSize = true;
            newPosL.Font = new Font("Segoe UI", 14F);
            newPosL.Location = new Point(754, 236);
            newPosL.Margin = new Padding(4, 0, 4, 0);
            newPosL.Name = "newPosL";
            newPosL.Size = new Size(190, 38);
            newPosL.TabIndex = 7;
            newPosL.Text = "Новый товар:";
            // 
            // addPosTB
            // 
            addPosTB.Font = new Font("Segoe UI", 14F);
            addPosTB.Location = new Point(754, 282);
            addPosTB.Margin = new Padding(4, 5, 4, 5);
            addPosTB.Name = "addPosTB";
            addPosTB.Size = new Size(300, 45);
            addPosTB.TabIndex = 8;
            // 
            // deleteAllBut
            // 
            deleteAllBut.BackColor = Color.DimGray;
            deleteAllBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteAllBut.ForeColor = Color.WhiteSmoke;
            deleteAllBut.Location = new Point(753, 674);
            deleteAllBut.Margin = new Padding(4, 5, 4, 5);
            deleteAllBut.Name = "deleteAllBut";
            deleteAllBut.Size = new Size(301, 82);
            deleteAllBut.TabIndex = 9;
            deleteAllBut.Text = "Очистить каталог";
            deleteAllBut.UseVisualStyleBackColor = false;
            deleteAllBut.Click += deleteAllBut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 777);
            Controls.Add(deleteAllBut);
            Controls.Add(addPosTB);
            Controls.Add(newPosL);
            Controls.Add(label2);
            Controls.Add(deleteBut);
            Controls.Add(addBut);
            Controls.Add(sortBut);
            Controls.Add(label1);
            Controls.Add(roleL);
            Controls.Add(listBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Каталог";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label roleL;
        private Label label1;
        private Button sortBut;
        private Button addBut;
        private Button deleteBut;
        private Label label2;
        private Label newPosL;
        private TextBox addPosTB;
        private Button deleteAllBut;
    }
}