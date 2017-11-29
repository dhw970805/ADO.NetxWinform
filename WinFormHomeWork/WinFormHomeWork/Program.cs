using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHomeWork
{
    static class Program
    {
      public static string useridl;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogorSign log=new LogorSign() ;
            Application.Run(log);
            //log.ShowDialog();
            if (log.DialogResult==DialogResult.OK)
            {
                Application .Run(new Form1(useridl));
            }
            //Application.Run(new Form1());
        }
    }
}
