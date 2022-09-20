using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestedProject
{
    static class Program
    {
        public static int parameter = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(args != null && args.Length > 0 && args[0] != null)
            {
                int.TryParse(args[0].ToString(), out int result);
                parameter = result;
            }
            Application.Run(new Form1());

        }
    }
}
