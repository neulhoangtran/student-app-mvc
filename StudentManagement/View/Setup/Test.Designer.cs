namespace NFramework.App.Init
{
    partial class Test
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
            lbl_setup_screen = new Label();
            lbl_language = new Label();
            textBox1 = new TextBox();
            txtdbName = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            btn_Next = new Button();
            label4 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // lbl_setup_screen
            // 
            lbl_setup_screen.AutoSize = true;
            lbl_setup_screen.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_setup_screen.ForeColor = Color.Coral;
            lbl_setup_screen.Location = new Point(214, 69);
            lbl_setup_screen.Name = "lbl_setup_screen";
            lbl_setup_screen.Size = new Size(402, 38);
            lbl_setup_screen.TabIndex = 0;
            lbl_setup_screen.Text = "SYSTEM CONFIGURATION";
            // 
            // lbl_language
            // 
            lbl_language.AutoSize = true;
            lbl_language.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_language.ForeColor = SystemColors.ButtonHighlight;
            lbl_language.Location = new Point(302, 108);
            lbl_language.Name = "lbl_language";
            lbl_language.Size = new Size(207, 28);
            lbl_language.TabIndex = 1;
            lbl_language.Text = "Select Language";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtdbName
            // 
            txtdbName.AutoSize = true;
            txtdbName.Font = new Font("Century Gothic", 11F);
            txtdbName.ForeColor = SystemColors.ButtonHighlight;
            txtdbName.Location = new Point(194, 150);
            txtdbName.Name = "txtdbName";
            txtdbName.Size = new Size(116, 20);
            txtdbName.TabIndex = 3;
            txtdbName.Text = "Database Host";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(194, 204);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 5;
            label1.Text = "Database Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(419, 23);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(192, 263);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 7;
            label2.Text = "Database User";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(419, 23);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(192, 321);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 9;
            label3.Text = "Database Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 346);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(419, 23);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.Coral;
            btn_Next.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Next.ForeColor = Color.White;
            btn_Next.Location = new Point(619, 365);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(151, 62);
            btn_Next.TabIndex = 10;
            btn_Next.Text = "NEXT";
            btn_Next.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(190, 379);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 12;
            label4.Text = "Database Port";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(192, 404);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(419, 23);
            textBox5.TabIndex = 11;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(btn_Next);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(txtdbName);
            Controls.Add(textBox1);
            Controls.Add(lbl_language);
            Controls.Add(lbl_setup_screen);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_setup_screen;
        private Label lbl_language;
        private TextBox textBox1;
        private Label txtdbName;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Button btn_Next;
        private Label label4;
        private TextBox textBox5;
    }
}