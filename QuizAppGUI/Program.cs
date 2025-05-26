using System;
using System.Windows.Forms;

namespace QuizAppGUI
{
    static class AppSession
    {
        public static string UserRole { get; set; } = "user";
        public static string UserName { get; set; } = "";
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    AppSession.UserRole = login.UserRole;
                    AppSession.UserName = login.UserName;
                    Application.Run(new Form1());
                }
            }
        }
    }
}
