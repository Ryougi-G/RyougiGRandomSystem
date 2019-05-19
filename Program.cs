using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RyougiGRandomSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("本程序有RyougiG开发，如有问题请联系1365654168@qq.com,或者在GITHUB上本项目发起ISSUE");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
