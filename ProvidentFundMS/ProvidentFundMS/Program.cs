using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidentFundMS
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

            //Application.Run(new 主界面());


            登录界面 loginForm = new 登录界面();
            DialogResult isOk = loginForm.ShowDialog();
            if (isOk == DialogResult.OK)
            {
                Application.Run(new 主界面());
            }
        }
    }
}