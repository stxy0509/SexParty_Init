using System;
using System.Windows.Forms;

namespace JqpdInit
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init_Form f = new Init_Form();
            Application.Run(f);
        }
    }
}
