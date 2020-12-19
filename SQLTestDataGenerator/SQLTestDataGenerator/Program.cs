using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SQLTestDataGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY4NzMxQDMxMzgyZTM0MmUzMG04Y1UxS3lSNDVyejVnZEVvdEgwUzRyUkRIdWZGM0xJd251ZXVLYmZOMDA9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
