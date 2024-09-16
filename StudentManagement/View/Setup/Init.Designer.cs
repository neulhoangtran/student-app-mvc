namespace StudentManagement.View.Setup
{
    partial class Init
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            pictureBoxStart = new PictureBox();
            timeStart = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            panel_txt_welcome = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStart).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxStart
            // 
            pictureBoxStart.Image = (Image)resources.GetObject("pictureBoxStart.Image");
            pictureBoxStart.Location = new Point(292, 77);
            pictureBoxStart.Name = "pictureBoxStart";
            pictureBoxStart.Size = new Size(206, 142);
            pictureBoxStart.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStart.TabIndex = 4;
            pictureBoxStart.TabStop = false;
            // 
            // timeStart
            // 
            timeStart.Interval = 3000;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Coral;
            btnStart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(292, 298);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 76);
            btnStart.TabIndex = 6;
            btnStart.Text = "START NOW";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Visible = false;
            btnStart.Click += btnStart_Click;
            // 
            // panel_txt_welcome
            // 
            panel_txt_welcome.BackColor = Color.Transparent;
            panel_txt_welcome.Location = new Point(124, 226);
            panel_txt_welcome.Name = "panel_txt_welcome";
            panel_txt_welcome.Size = new Size(553, 66);
            panel_txt_welcome.TabIndex = 5;
            panel_txt_welcome.Paint += panel_txt_welcome_Paint;
            // 
            // Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxStart);
            Controls.Add(btnStart);
            Controls.Add(panel_txt_welcome);
            Name = "Init";
            Text = "Init";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxStart;
        private System.Windows.Forms.Timer timeStart;
        private Button btnStart;
        private Panel panel_txt_welcome;
    }
}