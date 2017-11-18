namespace NULL
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.Controller = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RD_SMTP = new System.Windows.Forms.RadioButton();
            this.RD_Telegram = new System.Windows.Forms.RadioButton();
            this.GroupSMTP = new System.Windows.Forms.GroupBox();
            this.SMTP_Combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SMTP_IN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SMTP_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SMTP_User = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FakeM_Body = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RD_Disable = new System.Windows.Forms.RadioButton();
            this.RD_Error = new System.Windows.Forms.RadioButton();
            this.RD_Info = new System.Windows.Forms.RadioButton();
            this.RD_Question = new System.Windows.Forms.RadioButton();
            this.FakeM_Title = new System.Windows.Forms.TextBox();
            this.GroupTGApi = new System.Windows.Forms.GroupBox();
            this.Telegram_Token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Telegram_ID = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnBuild = new System.Windows.Forms.Button();
            this.GroupMethod = new System.Windows.Forms.GroupBox();
            this.GroupFMessage = new System.Windows.Forms.GroupBox();
            this.GroupBuild = new System.Windows.Forms.GroupBox();
            this.GroupIcon = new System.Windows.Forms.GroupBox();
            this.ChkIco9 = new System.Windows.Forms.RadioButton();
            this.ChkIco8 = new System.Windows.Forms.RadioButton();
            this.ChkIco7 = new System.Windows.Forms.RadioButton();
            this.ChkIco6 = new System.Windows.Forms.RadioButton();
            this.ChkIco5 = new System.Windows.Forms.RadioButton();
            this.ChkIco4 = new System.Windows.Forms.RadioButton();
            this.ChkIco3 = new System.Windows.Forms.RadioButton();
            this.ChkIco2 = new System.Windows.Forms.RadioButton();
            this.ChkIco1 = new System.Windows.Forms.RadioButton();
            this.IconPriv = new System.Windows.Forms.PictureBox();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.Light = new System.Windows.Forms.Panel();
            this.ChkIco00 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.GroupSMTP.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.GroupTGApi.SuspendLayout();
            this.GroupMethod.SuspendLayout();
            this.GroupFMessage.SuspendLayout();
            this.GroupBuild.SuspendLayout();
            this.GroupIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPriv)).BeginInit();
            this.SuspendLayout();
            // 
            // Controller
            // 
            this.Controller.Tick += new System.EventHandler(this.Controller_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BtnMinimize);
            this.panel1.Controls.Add(this.BtnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 22);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(637, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(33, 22);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.Text = "_";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.ForeColor = System.Drawing.Color.White;
            this.BtnMaximize.Location = new System.Drawing.Point(670, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(33, 22);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.Text = "[  ]";
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(703, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RD_SMTP
            // 
            this.RD_SMTP.AutoSize = true;
            this.RD_SMTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_SMTP.ForeColor = System.Drawing.Color.Black;
            this.RD_SMTP.Location = new System.Drawing.Point(6, 44);
            this.RD_SMTP.Name = "RD_SMTP";
            this.RD_SMTP.Size = new System.Drawing.Size(53, 19);
            this.RD_SMTP.TabIndex = 0;
            this.RD_SMTP.Text = "SMTP";
            this.RD_SMTP.UseVisualStyleBackColor = true;
            // 
            // RD_Telegram
            // 
            this.RD_Telegram.AutoSize = true;
            this.RD_Telegram.Checked = true;
            this.RD_Telegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Telegram.ForeColor = System.Drawing.Color.Black;
            this.RD_Telegram.Location = new System.Drawing.Point(6, 21);
            this.RD_Telegram.Name = "RD_Telegram";
            this.RD_Telegram.Size = new System.Drawing.Size(109, 19);
            this.RD_Telegram.TabIndex = 1;
            this.RD_Telegram.TabStop = true;
            this.RD_Telegram.Text = "Telegram API";
            this.RD_Telegram.UseVisualStyleBackColor = true;
            // 
            // GroupSMTP
            // 
            this.GroupSMTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupSMTP.Controls.Add(this.SMTP_Combo);
            this.GroupSMTP.Controls.Add(this.label6);
            this.GroupSMTP.Controls.Add(this.SMTP_IN);
            this.GroupSMTP.Controls.Add(this.label5);
            this.GroupSMTP.Controls.Add(this.SMTP_Pass);
            this.GroupSMTP.Controls.Add(this.label3);
            this.GroupSMTP.Controls.Add(this.label4);
            this.GroupSMTP.Controls.Add(this.SMTP_User);
            this.GroupSMTP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSMTP.ForeColor = System.Drawing.Color.Black;
            this.GroupSMTP.Location = new System.Drawing.Point(12, 176);
            this.GroupSMTP.Name = "GroupSMTP";
            this.GroupSMTP.Size = new System.Drawing.Size(213, 207);
            this.GroupSMTP.TabIndex = 15;
            this.GroupSMTP.TabStop = false;
            this.GroupSMTP.Text = " SMTP ";
            // 
            // SMTP_Combo
            // 
            this.SMTP_Combo.FormattingEnabled = true;
            this.SMTP_Combo.Items.AddRange(new object[] {
            "Gmail",
            "Yahoo",
            "Outlook",
            "Yandex"});
            this.SMTP_Combo.Location = new System.Drawing.Point(9, 41);
            this.SMTP_Combo.Name = "SMTP_Combo";
            this.SMTP_Combo.Size = new System.Drawing.Size(198, 23);
            this.SMTP_Combo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Receiver\'s Email";
            // 
            // SMTP_IN
            // 
            this.SMTP_IN.Location = new System.Drawing.Point(9, 169);
            this.SMTP_IN.Name = "SMTP_IN";
            this.SMTP_IN.Size = new System.Drawing.Size(195, 23);
            this.SMTP_IN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Your Password";
            // 
            // SMTP_Pass
            // 
            this.SMTP_Pass.Location = new System.Drawing.Point(9, 127);
            this.SMTP_Pass.Name = "SMTP_Pass";
            this.SMTP_Pass.Size = new System.Drawing.Size(195, 23);
            this.SMTP_Pass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Email";
            // 
            // SMTP_User
            // 
            this.SMTP_User.Location = new System.Drawing.Point(9, 85);
            this.SMTP_User.Name = "SMTP_User";
            this.SMTP_User.Size = new System.Drawing.Size(195, 23);
            this.SMTP_User.TabIndex = 4;
            // 
            // BtnTest
            // 
            this.BtnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTest.ForeColor = System.Drawing.Color.White;
            this.BtnTest.Location = new System.Drawing.Point(54, 223);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(108, 29);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = false;
            this.BtnTest.Click += new System.EventHandler(this.BTN_Test_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Body";
            // 
            // FakeM_Body
            // 
            this.FakeM_Body.Location = new System.Drawing.Point(16, 180);
            this.FakeM_Body.Name = "FakeM_Body";
            this.FakeM_Body.Size = new System.Drawing.Size(184, 23);
            this.FakeM_Body.TabIndex = 8;
            this.FakeM_Body.Text = "Windows cannot read required files. The file may be corrupt or missing. Make sure" +
    " all files required for installation are available, and restart the program Erro" +
    "r code: 0x80070570";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Title";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.RD_Disable);
            this.groupBox6.Controls.Add(this.RD_Error);
            this.groupBox6.Controls.Add(this.RD_Info);
            this.groupBox6.Controls.Add(this.RD_Question);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(16, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 78);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Icon ";
            // 
            // RD_Disable
            // 
            this.RD_Disable.AutoSize = true;
            this.RD_Disable.Checked = true;
            this.RD_Disable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Disable.ForeColor = System.Drawing.Color.Black;
            this.RD_Disable.Location = new System.Drawing.Point(16, 22);
            this.RD_Disable.Name = "RD_Disable";
            this.RD_Disable.Size = new System.Drawing.Size(74, 19);
            this.RD_Disable.TabIndex = 2;
            this.RD_Disable.TabStop = true;
            this.RD_Disable.Text = "Disable";
            this.RD_Disable.UseVisualStyleBackColor = true;
            // 
            // RD_Error
            // 
            this.RD_Error.AutoSize = true;
            this.RD_Error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Error.ForeColor = System.Drawing.Color.Black;
            this.RD_Error.Location = new System.Drawing.Point(98, 48);
            this.RD_Error.Name = "RD_Error";
            this.RD_Error.Size = new System.Drawing.Size(60, 19);
            this.RD_Error.TabIndex = 5;
            this.RD_Error.Text = "Error";
            this.RD_Error.UseVisualStyleBackColor = true;
            // 
            // RD_Info
            // 
            this.RD_Info.AutoSize = true;
            this.RD_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Info.ForeColor = System.Drawing.Color.Black;
            this.RD_Info.Location = new System.Drawing.Point(16, 48);
            this.RD_Info.Name = "RD_Info";
            this.RD_Info.Size = new System.Drawing.Size(53, 19);
            this.RD_Info.TabIndex = 3;
            this.RD_Info.Text = "Info";
            this.RD_Info.UseVisualStyleBackColor = true;
            // 
            // RD_Question
            // 
            this.RD_Question.AutoSize = true;
            this.RD_Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Question.ForeColor = System.Drawing.Color.Black;
            this.RD_Question.Location = new System.Drawing.Point(97, 22);
            this.RD_Question.Name = "RD_Question";
            this.RD_Question.Size = new System.Drawing.Size(81, 19);
            this.RD_Question.TabIndex = 4;
            this.RD_Question.Text = "Question";
            this.RD_Question.UseVisualStyleBackColor = true;
            // 
            // FakeM_Title
            // 
            this.FakeM_Title.Location = new System.Drawing.Point(16, 136);
            this.FakeM_Title.Name = "FakeM_Title";
            this.FakeM_Title.Size = new System.Drawing.Size(184, 23);
            this.FakeM_Title.TabIndex = 6;
            this.FakeM_Title.Text = "Error";
            // 
            // GroupTGApi
            // 
            this.GroupTGApi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupTGApi.Controls.Add(this.Telegram_Token);
            this.GroupTGApi.Controls.Add(this.label1);
            this.GroupTGApi.Controls.Add(this.label2);
            this.GroupTGApi.Controls.Add(this.Telegram_ID);
            this.GroupTGApi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTGApi.ForeColor = System.Drawing.Color.Black;
            this.GroupTGApi.Location = new System.Drawing.Point(12, 25);
            this.GroupTGApi.Name = "GroupTGApi";
            this.GroupTGApi.Size = new System.Drawing.Size(213, 133);
            this.GroupTGApi.TabIndex = 14;
            this.GroupTGApi.TabStop = false;
            this.GroupTGApi.Text = " Telegram API ";
            // 
            // Telegram_Token
            // 
            this.Telegram_Token.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Telegram_Token.Location = new System.Drawing.Point(15, 38);
            this.Telegram_Token.Name = "Telegram_Token";
            this.Telegram_Token.Size = new System.Drawing.Size(184, 23);
            this.Telegram_Token.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BotToken";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ChatID";
            // 
            // Telegram_ID
            // 
            this.Telegram_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Telegram_ID.Location = new System.Drawing.Point(15, 88);
            this.Telegram_ID.Name = "Telegram_ID";
            this.Telegram_ID.Size = new System.Drawing.Size(184, 23);
            this.Telegram_ID.TabIndex = 4;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(6, 162);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(191, 23);
            this.BtnBrowse.TabIndex = 19;
            this.BtnBrowse.Text = "Browse Icon";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Visible = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Location = new System.Drawing.Point(6, 320);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(249, 24);
            this.BtnAbout.TabIndex = 18;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // BtnBuild
            // 
            this.BtnBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuild.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BtnBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.BtnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuild.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnBuild.ForeColor = System.Drawing.Color.White;
            this.BtnBuild.Location = new System.Drawing.Point(6, 278);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(248, 32);
            this.BtnBuild.TabIndex = 17;
            this.BtnBuild.Text = "Build";
            this.BtnBuild.UseVisualStyleBackColor = false;
            this.BtnBuild.Click += new System.EventHandler(this.BTN_Build_Click);
            // 
            // GroupMethod
            // 
            this.GroupMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupMethod.Controls.Add(this.RD_SMTP);
            this.GroupMethod.Controls.Add(this.RD_Telegram);
            this.GroupMethod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMethod.ForeColor = System.Drawing.Color.Black;
            this.GroupMethod.Location = new System.Drawing.Point(232, 25);
            this.GroupMethod.Name = "GroupMethod";
            this.GroupMethod.Size = new System.Drawing.Size(231, 71);
            this.GroupMethod.TabIndex = 16;
            this.GroupMethod.TabStop = false;
            this.GroupMethod.Text = " Transport Type";
            // 
            // GroupFMessage
            // 
            this.GroupFMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupFMessage.Controls.Add(this.BtnTest);
            this.GroupFMessage.Controls.Add(this.label8);
            this.GroupFMessage.Controls.Add(this.FakeM_Body);
            this.GroupFMessage.Controls.Add(this.label7);
            this.GroupFMessage.Controls.Add(this.groupBox6);
            this.GroupFMessage.Controls.Add(this.FakeM_Title);
            this.GroupFMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupFMessage.ForeColor = System.Drawing.Color.Black;
            this.GroupFMessage.Location = new System.Drawing.Point(232, 102);
            this.GroupFMessage.Name = "GroupFMessage";
            this.GroupFMessage.Size = new System.Drawing.Size(231, 281);
            this.GroupFMessage.TabIndex = 13;
            this.GroupFMessage.TabStop = false;
            this.GroupFMessage.Text = " Fake Message ";
            // 
            // GroupBuild
            // 
            this.GroupBuild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBuild.Controls.Add(this.BtnBuild);
            this.GroupBuild.Controls.Add(this.GroupIcon);
            this.GroupBuild.Controls.Add(this.BtnAbout);
            this.GroupBuild.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBuild.ForeColor = System.Drawing.Color.Black;
            this.GroupBuild.Location = new System.Drawing.Point(469, 25);
            this.GroupBuild.Name = "GroupBuild";
            this.GroupBuild.Size = new System.Drawing.Size(260, 358);
            this.GroupBuild.TabIndex = 22;
            this.GroupBuild.TabStop = false;
            this.GroupBuild.Text = "Build";
            // 
            // GroupIcon
            // 
            this.GroupIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupIcon.Controls.Add(this.ChkIco00);
            this.GroupIcon.Controls.Add(this.ChkIco9);
            this.GroupIcon.Controls.Add(this.ChkIco8);
            this.GroupIcon.Controls.Add(this.ChkIco7);
            this.GroupIcon.Controls.Add(this.ChkIco6);
            this.GroupIcon.Controls.Add(this.ChkIco5);
            this.GroupIcon.Controls.Add(this.ChkIco4);
            this.GroupIcon.Controls.Add(this.ChkIco3);
            this.GroupIcon.Controls.Add(this.ChkIco2);
            this.GroupIcon.Controls.Add(this.ChkIco1);
            this.GroupIcon.Controls.Add(this.BtnBrowse);
            this.GroupIcon.Controls.Add(this.IconPriv);
            this.GroupIcon.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupIcon.ForeColor = System.Drawing.Color.Black;
            this.GroupIcon.Location = new System.Drawing.Point(10, 15);
            this.GroupIcon.Name = "GroupIcon";
            this.GroupIcon.Size = new System.Drawing.Size(241, 200);
            this.GroupIcon.TabIndex = 23;
            this.GroupIcon.TabStop = false;
            this.GroupIcon.Text = " Icon";
            // 
            // ChkIco9
            // 
            this.ChkIco9.AutoSize = true;
            this.ChkIco9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco9.Location = new System.Drawing.Point(6, 134);
            this.ChkIco9.Name = "ChkIco9";
            this.ChkIco9.Size = new System.Drawing.Size(67, 19);
            this.ChkIco9.TabIndex = 23;
            this.ChkIco9.Text = "Custom";
            this.ChkIco9.UseVisualStyleBackColor = true;
            this.ChkIco9.CheckedChanged += new System.EventHandler(this.ChkIco9_CheckedChanged);
            // 
            // ChkIco8
            // 
            this.ChkIco8.AutoSize = true;
            this.ChkIco8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco8.Location = new System.Drawing.Point(85, 108);
            this.ChkIco8.Name = "ChkIco8";
            this.ChkIco8.Size = new System.Drawing.Size(46, 19);
            this.ChkIco8.TabIndex = 23;
            this.ChkIco8.Text = "ZIP";
            this.ChkIco8.UseVisualStyleBackColor = true;
            // 
            // ChkIco7
            // 
            this.ChkIco7.AutoSize = true;
            this.ChkIco7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco7.Location = new System.Drawing.Point(6, 106);
            this.ChkIco7.Name = "ChkIco7";
            this.ChkIco7.Size = new System.Drawing.Size(46, 19);
            this.ChkIco7.TabIndex = 23;
            this.ChkIco7.Text = "JPG";
            this.ChkIco7.UseVisualStyleBackColor = true;
            // 
            // ChkIco6
            // 
            this.ChkIco6.AutoSize = true;
            this.ChkIco6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco6.Location = new System.Drawing.Point(85, 79);
            this.ChkIco6.Name = "ChkIco6";
            this.ChkIco6.Size = new System.Drawing.Size(46, 19);
            this.ChkIco6.TabIndex = 23;
            this.ChkIco6.Text = "MP3";
            this.ChkIco6.UseVisualStyleBackColor = true;
            // 
            // ChkIco5
            // 
            this.ChkIco5.AutoSize = true;
            this.ChkIco5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco5.Location = new System.Drawing.Point(6, 78);
            this.ChkIco5.Name = "ChkIco5";
            this.ChkIco5.Size = new System.Drawing.Size(46, 19);
            this.ChkIco5.TabIndex = 23;
            this.ChkIco5.Text = "I.E";
            this.ChkIco5.UseVisualStyleBackColor = true;
            // 
            // ChkIco4
            // 
            this.ChkIco4.AutoSize = true;
            this.ChkIco4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco4.Location = new System.Drawing.Point(85, 50);
            this.ChkIco4.Name = "ChkIco4";
            this.ChkIco4.Size = new System.Drawing.Size(67, 19);
            this.ChkIco4.TabIndex = 23;
            this.ChkIco4.Text = "Python";
            this.ChkIco4.UseVisualStyleBackColor = true;
            // 
            // ChkIco3
            // 
            this.ChkIco3.AutoSize = true;
            this.ChkIco3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco3.Location = new System.Drawing.Point(6, 50);
            this.ChkIco3.Name = "ChkIco3";
            this.ChkIco3.Size = new System.Drawing.Size(67, 19);
            this.ChkIco3.TabIndex = 23;
            this.ChkIco3.Text = "Folder";
            this.ChkIco3.UseVisualStyleBackColor = true;
            this.ChkIco3.CheckedChanged += new System.EventHandler(this.ChkIco3_CheckedChanged);
            // 
            // ChkIco2
            // 
            this.ChkIco2.AutoSize = true;
            this.ChkIco2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco2.Location = new System.Drawing.Point(85, 22);
            this.ChkIco2.Name = "ChkIco2";
            this.ChkIco2.Size = new System.Drawing.Size(67, 19);
            this.ChkIco2.TabIndex = 23;
            this.ChkIco2.Text = "Chrome";
            this.ChkIco2.UseVisualStyleBackColor = true;
            // 
            // ChkIco1
            // 
            this.ChkIco1.AutoSize = true;
            this.ChkIco1.Checked = true;
            this.ChkIco1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco1.Location = new System.Drawing.Point(6, 22);
            this.ChkIco1.Name = "ChkIco1";
            this.ChkIco1.Size = new System.Drawing.Size(53, 19);
            this.ChkIco1.TabIndex = 23;
            this.ChkIco1.TabStop = true;
            this.ChkIco1.Text = "Java";
            this.ChkIco1.UseVisualStyleBackColor = true;
            // 
            // IconPriv
            // 
            this.IconPriv.Location = new System.Drawing.Point(158, 29);
            this.IconPriv.Name = "IconPriv";
            this.IconPriv.Size = new System.Drawing.Size(77, 87);
            this.IconPriv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPriv.TabIndex = 21;
            this.IconPriv.TabStop = false;
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(122)))), ((int)(((byte)(225)))));
            this.LabelAbout.Location = new System.Drawing.Point(12, 390);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(0, 15);
            this.LabelAbout.TabIndex = 23;
            // 
            // Light
            // 
            this.Light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.Light.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Light.Location = new System.Drawing.Point(0, 412);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(736, 4);
            this.Light.TabIndex = 24;
            // 
            // ChkIco00
            // 
            this.ChkIco00.AutoSize = true;
            this.ChkIco00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkIco00.Location = new System.Drawing.Point(85, 134);
            this.ChkIco00.Name = "ChkIco00";
            this.ChkIco00.Size = new System.Drawing.Size(67, 19);
            this.ChkIco00.TabIndex = 24;
            this.ChkIco00.Text = "NoIcon";
            this.ChkIco00.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(736, 416);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.GroupBuild);
            this.Controls.Add(this.GroupMethod);
            this.Controls.Add(this.GroupSMTP);
            this.Controls.Add(this.GroupFMessage);
            this.Controls.Add(this.GroupTGApi);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeleShadow 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.GroupSMTP.ResumeLayout(false);
            this.GroupSMTP.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.GroupTGApi.ResumeLayout(false);
            this.GroupTGApi.PerformLayout();
            this.GroupMethod.ResumeLayout(false);
            this.GroupMethod.PerformLayout();
            this.GroupFMessage.ResumeLayout(false);
            this.GroupFMessage.PerformLayout();
            this.GroupBuild.ResumeLayout(false);
            this.GroupIcon.ResumeLayout(false);
            this.GroupIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPriv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Controller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton RD_SMTP;
        private System.Windows.Forms.RadioButton RD_Telegram;
        private System.Windows.Forms.GroupBox GroupSMTP;
        private System.Windows.Forms.ComboBox SMTP_Combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SMTP_IN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SMTP_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SMTP_User;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FakeM_Body;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton RD_Disable;
        private System.Windows.Forms.RadioButton RD_Error;
        private System.Windows.Forms.RadioButton RD_Info;
        private System.Windows.Forms.RadioButton RD_Question;
        private System.Windows.Forms.TextBox FakeM_Title;
        private System.Windows.Forms.GroupBox GroupTGApi;
        private System.Windows.Forms.TextBox Telegram_Token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Telegram_ID;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnBuild;
        private System.Windows.Forms.PictureBox IconPriv;
        private System.Windows.Forms.GroupBox GroupMethod;
        private System.Windows.Forms.GroupBox GroupFMessage;
        private System.Windows.Forms.GroupBox GroupBuild;
        private System.Windows.Forms.GroupBox GroupIcon;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.RadioButton ChkIco9;
        private System.Windows.Forms.RadioButton ChkIco8;
        private System.Windows.Forms.RadioButton ChkIco7;
        private System.Windows.Forms.RadioButton ChkIco6;
        private System.Windows.Forms.RadioButton ChkIco5;
        private System.Windows.Forms.RadioButton ChkIco4;
        private System.Windows.Forms.RadioButton ChkIco3;
        private System.Windows.Forms.RadioButton ChkIco2;
        private System.Windows.Forms.RadioButton ChkIco1;
        private System.Windows.Forms.Panel Light;
        private System.Windows.Forms.RadioButton ChkIco00;
    }
}

