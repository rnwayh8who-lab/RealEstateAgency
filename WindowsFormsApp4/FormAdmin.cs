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
using Microsoft.VisualBasic;

namespace WindowsFormsApp4
{
    public partial class FormAdmin : Form
    {
        SqlDB db = new SqlDB();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private int GetSelectedEmployeeID()
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника в таблице!");
                return -1;
            }

            return Convert.ToInt32(
                dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value
            );
        }

        private void LoadEmployees()
        {
            db.showTable(dataGridViewEmployees);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadEmployees();

            comboShift.Items.Add("Day");
            comboShift.Items.Add("Evening");
            comboShift.Items.Add("Night");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = GetSelectedEmployeeID();
            SqlConnection conn = SqlDB.GetConnection();
            if (id == -1) return;

            string query = "UPDATE Employees SET Status='Fired' WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Сотрудник уволен.");
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string role = textBoxRole.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string phone = textBoxPhone.Text;
            SqlConnection conn = SqlDB.GetConnection();

            if (name == "" || role == "" || login == "" || password == "" || phone == "")
            {
                MessageBox.Show("Заполните все поля: ФИО, роль, логин, пароль, телефон!");
                return;
            }

            string query = @"INSERT INTO Employees 
                    (FullName, Role, Status, Phone, Login, Password, Shift)
                    VALUES (@name, @role, 'Active', @phone, @login, @pass, '')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pass", password);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Работник успешно добавлен!");
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSetRealtor_Click(object sender, EventArgs e)
        {
            int id = GetSelectedEmployeeID();
            SqlConnection conn = SqlDB.GetConnection();
            if (id == -1) return;

            string query = "UPDATE Employees SET Role='Realtor' WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Работник назначен риелтором.");
        }

        private void btnSetLawyer_Click(object sender, EventArgs e)
        {
            int id = GetSelectedEmployeeID();
            SqlConnection conn = SqlDB.GetConnection();
            if (id == -1) return;

            string query = "UPDATE Employees SET Role='Lawyer' WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Работник назначен юристом.");
        }

        private void btnSetShift_Click(object sender, EventArgs e)
        {
            int id = GetSelectedEmployeeID();
            SqlConnection conn = SqlDB.GetConnection();
            if (id == -1) return;

            if (comboShift.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите смену!");
                return;
            }

            string shift = comboShift.SelectedItem.ToString();

            string query = "UPDATE Employees SET Shift=@shift WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@shift", shift);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Смена изменена.");
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника!");
                return;
            }

            int id = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);

            SqlConnection conn = SqlDB.GetConnection();
            string query = "DELETE FROM Employees WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();
            MessageBox.Show("Сотрудник удалён.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            db.searchInTable(dataGridViewEmployees, textBoxSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.saveTable(dataGridViewEmployees);
        }
        private void dataGridViewEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            db.rows.Add(e.RowIndex);
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            int id = GetSelectedEmployeeID();
            if (id == -1) return;

            SqlConnection conn = SqlDB.GetConnection();

            string query = "UPDATE Employees SET Status='Blocked' WHERE EmployeeID=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadEmployees();

            MessageBox.Show("Учётная запись деактивирована.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
