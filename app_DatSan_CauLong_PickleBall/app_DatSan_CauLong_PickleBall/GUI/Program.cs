using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin loginForm = new FormLogin();
            loginForm.Opacity = 0;  // Ẩn form ban đầu

            // Dùng Task để không chặn UI
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000); // Giả lập load dữ liệu

                loginForm.Invoke(new Action(() =>
                {
                    loginForm.Opacity = 1; // Hiện form lên sau khi load xong
                }));
            });
            Application.Run(loginForm);
        }
    }
}
