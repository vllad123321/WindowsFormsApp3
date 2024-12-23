using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Открываем форму регистрации
            var registerForm = new FormRegister();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                // После успешной регистрации открываем основное окно
                Application.Run(new Form1());
            }
            else
            {
                // Если регистрация не прошла, приложение закрывается
                Application.Exit();
            }
        }
    }
}
