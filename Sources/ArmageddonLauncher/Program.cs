using System;
using System.Linq;
using System.Windows.Forms;
using ApocalypseLauncher.UI;

namespace ApocalypseLauncher
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main(string[] keys)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            if (keys.Any())
            {
                switch (keys[0])
                { 
                    case "--upgrade":
                        if (keys.Length == 3) {
                            MessageBox.Show(@"Replace from " + keys[1] + @" to " + keys[2] + @" with argument -upgrade",
                            @"DEBUG");
                        }
                        Application.Exit();
                        return; 
                        //case "--init":
                        //    MessageBox.Show(@"First run with argument -init", @"DEBUG");
                        //   return;
                    default:
                        Application.Run(new FrmMain());
                        return;
                }
            }
            Application.Run(new FrmMain());
        }
    }
}