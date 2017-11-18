using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace NULL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Protector())
            {
                Application.Exit();
            }
            else
            {
                Application.Run(new Main());
            }
        }
        static bool Protector()
        { 
            string[] FileDB =
                {
                "Stubx",
                @"Icon\SAR1.ico",
                @"Icon\SAR2.ico",
                @"Icon\SAR3.ico",
                @"Icon\SAR4.ico",
                @"Icon\SAR5.ico",
                @"Icon\SAR6.ico"
                };
            foreach (var Single in FileDB)
            {
                if (!File.Exists(Single))
                {
                    MessageBox.Show("File \"" + Single + "\" Not Exists! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

    }
}
