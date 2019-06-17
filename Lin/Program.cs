using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        { 
            StaticContainer.isTest = args.Length > 0 && string.CompareOrdinal(args[0], "test") == 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
