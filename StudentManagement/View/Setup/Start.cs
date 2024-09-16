using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Reflection.Emit;

namespace NFramework.App.Init
{
    public partial class Start : Form
    {
        private float opacity = 0.0f;
        private int elapsed = 0;

        private Label lblAppName;
        private Label lblLocale;
        private TextBox txtAppName;
        private Label lblHeading;
        private Button btnNextToDatabase;
        private Button btnNextSetupModule;
        private Button btnTestConnect;


        private TextBox txt_DBHost;
        private TextBox txt_DBName;
        private TextBox txt_DBUser;
        private TextBox txt_DBPassword;
        private TextBox txt_DBPort;

        private Label lbl_selct_db_heading;
        private Label lbl_DBHost;
        private Label lbl_DBName;
        private Label lbl_DBUser;
        private Label lbl_DBPassword;
        private Label lbl_DBPort;
        //private ComboBox cbLanguages;
        public Start()
        {
            InitializeComponent();
            timeStart.Interval = 100;
            timeStart.Tick += timeStart_Tick;
            timeStart.Start();
            btnStart.Visible = false;
            SetupConfiguationScreen();
        }

        private void timeStart_Tick(object sender, EventArgs e)
        {
            elapsed += timeStart.Interval;
            //lbl_wellcome.Visible = true;
            if (elapsed >= 6000)
            {
                // Thực hiện fade-in
                if (opacity < 1.0f)
                {
                    opacity += 0.05f; // Tăng độ mờ dần dần
                    panel_txt_welcome.Invalidate(); // Yêu cầu vẽ lại Panel
                }
                else
                {
                    timeStart.Stop(); // Dừng Timer khi đạt độ mờ tối đa
                    btnStart.Visible = true;
                }
            }
        }

        private void panel_txt_welcome_Paint(object sender, PaintEventArgs e)
        {
            // Tạo brush với độ mờ hiện tại
            using (Brush brush = new SolidBrush(Color.FromArgb((int)(opacity * 255), Color.White)))
            {
                // Đo kích thước của text để căn giữa
                string text = "WELCOME TO NFW";
                Font font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Tính toán vị trí để vẽ text ở giữa Panel
                float x = (panel_txt_welcome.Width - textSize.Width) / 2;
                float y = (panel_txt_welcome.Height - textSize.Height) / 2;

                // Vẽ text với vị trí căn giữa
                e.Graphics.DrawString(text, font, brush, new PointF(x, y));
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            panel_txt_welcome.Visible = false;
            pictureBoxStart.Visible = false;
            lblHeading.Visible = true;
            lblAppName.Visible = true;
            txtAppName.Visible = true;
            btnNextToDatabase.Visible = true;
            //lblLocale.Visible = true;
        }
        
        private void btnNextToDatabase_Click(object sender, EventArgs e)
        {
            //btnStart.Visible = false;
            //panel_txt_welcome.Visible = false;
            //pictureBoxStart.Visible = false;
            //lblHeading.Visible = false;
            lblAppName.Visible = false;
            txtAppName.Visible = false;
            btnNextToDatabase.Visible = false;

            lbl_selct_db_heading.Visible = true;
            txt_DBHost.Visible = true;
            lbl_DBHost.Visible = true;

            txt_DBName.Visible = true;
            lbl_DBName.Visible = true;

            txt_DBUser.Visible = true;
            lbl_DBUser.Visible = true;

            txt_DBPassword.Visible = true;
            lbl_DBPassword.Visible = true;

            txt_DBPort.Visible = true;
            lbl_DBPort.Visible = true;

            btnNextSetupModule.Visible = true;
            btnTestConnect.Visible = true;

        //lblLocale.Visible = true;
    }

        private void SetupConfiguationScreen()
        {
            InitialConfigHeadingText();
            InitialSetupLanguageScreen();
            InitialSetupAppScreen();
            InitialSetupDatabaseScreen();
        }
        private void InitialConfigHeadingText()
        {
            lblHeading = new Label
            {
                Text = "SYSTEM CONFIGURATION",
                Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Coral,
                Location = new Point(214, 69),
                AutoSize = true,
                Visible = false // hide after init
            };
            this.Controls.Add(lblHeading);
        }

        private void InitialSetupLanguageScreen()
        {

            lblLocale = new Label
            {
                Text = "Select Language",
                Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(303, 133),
                AutoSize = true,
                Visible = false // hide after init
            };
            
            this.Controls.Add(lblLocale);

        }

        private void InitialSetupAppScreen()
        {
            lblAppName = new Label
            {
                Text = "Enter the app name",
                Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(303, 133),
                AutoSize = true,
                Visible = false // hide after init


            };
            this.Controls.Add(lblAppName);

            txtAppName = new TextBox
            {
                Location = new Point(197, 209),
                Name = "txtAppName",
                Size = new Size(419, 40),
                TabIndex = 2,
                TextAlign = HorizontalAlignment.Center,
                Visible = false
            };
            this.Controls.Add(txtAppName);

            btnNextToDatabase = new Button();
            btnNextToDatabase.BackColor = Color.Coral;
            btnNextToDatabase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextToDatabase.Location = new Point(292, 280);
            btnNextToDatabase.Name = "btnNextToDatabase";
            btnNextToDatabase.Size = new Size(206, 60);
            btnNextToDatabase.TabIndex = 3;
            btnNextToDatabase.Text = "NEXT";
            btnNextToDatabase.UseVisualStyleBackColor = false;
            btnNextToDatabase.Visible = false;
            btnNextToDatabase.Click += btnNextToDatabase_Click;

            this.Controls.Add(btnNextToDatabase);
        }

        private void InitialSetupDatabaseScreen()
        {
            lbl_DBHost = new Label();
            lbl_DBName = new Label();
            lbl_DBUser = new Label();
            lbl_DBPassword = new Label();
            lbl_DBPort = new Label();

            btnNextSetupModule = new Button();
            btnTestConnect = new Button();

            lbl_selct_db_heading = new Label();

            txt_DBHost = new TextBox();
            txt_DBName = new TextBox();
            txt_DBUser = new TextBox();
            txt_DBPassword = new TextBox();
            txt_DBPort = new TextBox();

            lbl_selct_db_heading.AutoSize = true;
            lbl_selct_db_heading.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_selct_db_heading.ForeColor = SystemColors.ButtonHighlight;
            lbl_selct_db_heading.Location = new Point(302, 108);
            lbl_selct_db_heading.Name = "lbl_language";
            lbl_selct_db_heading.Size = new Size(207, 28);
            lbl_selct_db_heading.TabIndex = 1;
            lbl_selct_db_heading.Text = "Enter the database";
            lbl_selct_db_heading.Visible = false;


            // DBHost
            txt_DBHost.Location = new Point(196, 175);
            txt_DBHost.Name = "txt_DBHost";
            txt_DBHost.Size = new Size(419, 23);
            txt_DBHost.TabIndex = 2;
            txt_DBHost.TextAlign = HorizontalAlignment.Center;
            txt_DBHost.Visible = false;
            
            lbl_DBHost.AutoSize = true;
            lbl_DBHost.Font = new Font("Century Gothic", 11F);
            lbl_DBHost.ForeColor = SystemColors.ButtonHighlight;
            lbl_DBHost.Location = new Point(194, 150);
            lbl_DBHost.Name = "txtdbName";
            lbl_DBHost.Size = new Size(116, 20);
            lbl_DBHost.TabIndex = 3;
            lbl_DBHost.Text = "Database Host";
            lbl_DBHost.Visible = false;


            // DBName

            txt_DBName.Location = new Point(196, 229);
            txt_DBName.Name = "txt_DBName";
            txt_DBName.Size = new Size(419, 23);
            txt_DBName.TabIndex = 4;
            txt_DBName.TextAlign = HorizontalAlignment.Center;
            txt_DBName.Visible = false;

            lbl_DBName.AutoSize = true;
            lbl_DBName.Font = new Font("Century Gothic", 11F);
            lbl_DBName.ForeColor = SystemColors.ButtonHighlight;
            lbl_DBName.Location = new Point(192, 204);
            lbl_DBName.Name = "lbl_DBName";
            lbl_DBName.Size = new Size(117, 20);
            lbl_DBName.TabIndex = 7;
            lbl_DBName.Text = "Database Name";
            lbl_DBName.Visible = false;



            txt_DBUser.Location = new Point(194, 288);
            txt_DBUser.Name = "txt_DBUser";
            txt_DBUser.Size = new Size(419, 23);
            txt_DBUser.TabIndex = 6;
            txt_DBUser.TextAlign = HorizontalAlignment.Center;
            txt_DBUser.Visible = false;
            // 
            // label3
            // 
            lbl_DBUser.AutoSize = true;
            lbl_DBUser.Font = new Font("Century Gothic", 11F);
            lbl_DBUser.ForeColor = SystemColors.ButtonHighlight;
            lbl_DBUser.Location = new Point(192, 263);
            lbl_DBUser.Name = "lbl_DBUser";
            lbl_DBUser.Size = new Size(155, 20);
            lbl_DBUser.TabIndex = 9;
            lbl_DBUser.Text = "Database User";
            lbl_DBUser.Visible = false;


            lbl_DBPassword.AutoSize = true;
            lbl_DBPassword.Font = new Font("Century Gothic", 11F);
            lbl_DBPassword.ForeColor = SystemColors.ButtonHighlight;
            lbl_DBPassword.Location = new Point(190, 321);
            lbl_DBPassword.Name = "lbl_DBPassword";
            lbl_DBPassword.Size = new Size(114, 20);
            lbl_DBPassword.TabIndex = 12;
            lbl_DBPassword.Text = "Database password";
            lbl_DBPassword.Visible = false;

            txt_DBPassword.Location = new Point(194, 346);
            txt_DBPassword.Name = "txt_DBPassword";
            txt_DBPassword.Size = new Size(419, 23);
            txt_DBPassword.TabIndex = 8;
            txt_DBPassword.TextAlign = HorizontalAlignment.Center;
            txt_DBPassword.Visible = false;

            // DB port
            lbl_DBPort.AutoSize = true;
            lbl_DBPort.Font = new Font("Century Gothic", 11F);
            lbl_DBPort.ForeColor = SystemColors.ButtonHighlight;
            lbl_DBPort.Location = new Point(190, 379);
            lbl_DBPort.Name = "lbl_DBPort";
            lbl_DBPort.Size = new Size(114, 20);
            lbl_DBPort.TabIndex = 12;
            lbl_DBPort.Text = "Database port";
            lbl_DBPort.Visible = false;

            txt_DBPort.Location = new Point(194, 404);
            txt_DBPort.Name = "txt_DBPort";
            txt_DBPort.Size = new Size(419, 23);
            txt_DBPort.TabIndex = 8;
            txt_DBPort.TextAlign = HorizontalAlignment.Center;
            txt_DBPort.Visible = false;

            // 
            // btn_Next
            // 
            btnNextSetupModule.BackColor = Color.Coral;
            btnNextSetupModule.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextSetupModule.ForeColor = Color.White;
            btnNextSetupModule.Location = new Point(619, 365);
            btnNextSetupModule.Name = "btnNextSetupModule";
            btnNextSetupModule.Size = new Size(151, 62);
            btnNextSetupModule.TabIndex = 10;
            btnNextSetupModule.Text = "NEXT";
            btnNextSetupModule.UseVisualStyleBackColor = false;
            btnNextSetupModule.Visible = false;


            btnTestConnect.BackColor = Color.Coral;
            btnTestConnect.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnect.ForeColor = Color.White;
            btnTestConnect.Location = new Point(619, 300);
            btnTestConnect.Name = "btnTestConnect";
            btnTestConnect.Size = new Size(151, 62);
            btnTestConnect.TabIndex = 10;
            btnTestConnect.Text = "TEST";
            btnTestConnect.UseVisualStyleBackColor = false;
            btnTestConnect.Visible = false;


            this.Controls.Add(lbl_selct_db_heading);
            this.Controls.Add(lbl_DBHost);
            this.Controls.Add(txt_DBHost);

            this.Controls.Add(lbl_DBName);
            this.Controls.Add(txt_DBName);

            this.Controls.Add(lbl_DBUser);
            this.Controls.Add(txt_DBUser);

            this.Controls.Add(lbl_DBPassword);
            this.Controls.Add(txt_DBPassword);

            this.Controls.Add(lbl_DBPort);
            this.Controls.Add(txt_DBPort);

            this.Controls.Add(btnTestConnect);
            this.Controls.Add(btnNextSetupModule);
        }
    }
}
