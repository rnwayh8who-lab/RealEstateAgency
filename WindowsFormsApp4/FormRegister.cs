using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
                textBoxPassword.PasswordChar = '\0';   // показать пароль
            else
                textBoxPassword.PasswordChar = '*';    // скрыть пароль
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxFullName.Text;
            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;
            string phone = textBoxPhone.Text;

            if (name == "" || login == "" || pass == "" || phone == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            SqlConnection conn = SqlDB.GetConnection();

            // Проверка уникального логина
            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Login=@login", conn);
            check.Parameters.AddWithValue("@login", login);

            conn.Open();
            int count = (int)check.ExecuteScalar();

            if (count > 0)
            {
                conn.Close();
                MessageBox.Show("Логин уже используется! Введите другой.");
                return;
            }

            // Регистрация нового пользователя как "User"
            string query = @"INSERT INTO Employees 
                            (FullName, Role, Status, Phone, Login, Password, Shift)
                            VALUES (@n, 'User', 'Active', @p, @l, @pw, '')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@l", login);
            cmd.Parameters.AddWithValue("@pw", pass);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Регистрация прошла успешно!\nОбратитесь к администратору для назначения роли.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
