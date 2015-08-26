using System;
using System.Windows.Forms;

namespace JqpdInit
{
    static class Program
    {
        public static int sale = 0;
        public static int lineNumber = 100;
        public static int[] ln = new int[3]{1,0,0};
        public static int machineNumber = 123;
        public static int[] mn = new int[3]{1,2,3};
        public static int nCodeTime = 20;
        public static int startNum = 0;
        public static int currentNum = 0;
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
