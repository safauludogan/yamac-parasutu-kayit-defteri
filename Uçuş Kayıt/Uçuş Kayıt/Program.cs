using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Uçuş_Kayıt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //u=[ProductCode]

            if (args.Length > 0)
            {
                string arg = args[0].Substring(0, 2).ToLower();
                if (arg == "/u")
                {
                    string[] parametreler = args[0].Split('=');
                    string prodCode = parametreler[1];
                    string adres = Environment.GetFolderPath(Environment.SpecialFolder.System);
                    Process prc = new Process();
                    prc.StartInfo.FileName = string.Concat(adres, "\\msiexec.exe");
                    prc.StartInfo.Arguments = string.Concat("/i", prodCode);
                    prc.Start();
                }// remove , repair : /i
                // remove : /x
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new giris());
            }
        }
    }
}
