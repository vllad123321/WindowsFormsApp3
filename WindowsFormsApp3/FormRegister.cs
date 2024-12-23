using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Логика сохранения данных (в данном примере - в памяти, для простоты)
            // В реальном приложении можно использовать базы данных или файлы для хранения
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Save();

            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Закрыть окно регистрации и перейти к главному окну
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрыть окно без регистрации
        }
    }
}
