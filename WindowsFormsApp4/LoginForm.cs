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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SqlConnection conn = SqlDB.GetConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            using (SqlConnection conn = SqlDB.GetConnection())
            {
                string query = @"SELECT EmployeeID, FullName, Role, Status 
                 FROM Employees
                 WHERE Login=@login AND Password=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    string status = reader["Status"].ToString();
                    Session.CurrentUserID = Convert.ToInt32(reader["EmployeeID"]);
                    Session.CurrentRole = reader["Role"].ToString();
                    Session.CurrentFullName = reader["FullName"].ToString();

                    conn.Close();

                    if (status == "Fired")
                    {
                        MessageBox.Show("Сотрудник уволен. Доступ запрещён.");
                        return;
                    }

                    if (role == "Administrator")
                    {
                        new FormAdmin().Show();
                    }
                    else if (role == "Realtor")
                    {
                        new FormRealtor().Show();
                    }
                    else if (role == "Lawyer")
                    {
                        new FormLawyer().Show();
                    }

                    this.Hide();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
