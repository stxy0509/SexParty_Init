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
            TX_Form f = new TX_Form();
            Application.Run(f);
        }
    }
}
