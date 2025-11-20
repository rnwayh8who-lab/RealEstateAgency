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
    public partial class FormRealtor : Form
    {
        int RealtorID;
        public FormRealtor()
        {
            InitializeComponent();
            RealtorID = Session.CurrentUserID;
        }

        private void LoadOrders()
        {
            SqlConnection conn = SqlDB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Orders.OrderID, Clients.FullName AS Client, Property.Address,
                         Orders.Status, Orders.CreatedDate
                  FROM Orders
                  JOIN Clients ON Orders.ClientID = Clients.ClientID
                  JOIN Property ON Orders.PropertyID = Property.PropertyID
                  WHERE Orders.EmployeeID = @id",
                conn);

            da.SelectCommand.Parameters.AddWithValue("@id", RealtorID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewOrders.DataSource = dt;
        }

        private void LoadClients()
        {
            SqlConnection conn = SqlDB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT ClientID, FullName, Phone, Email FROM Clients",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewClients.DataSource = dt;
        }

        private void LoadDocuments(int orderID)
        {
            SqlConnection conn = SqlDB.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT DocumentID,
                 DocName,
                 FilePath,
                 Status
          FROM Documents
          WHERE OrderID = @id",
                conn);

            da.SelectCommand.Parameters.AddWithValue("@id", orderID);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewDocs.DataSource = dt;
        }

        private void SetStatus(string status)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ!");
                return;
            }

            int orderID = Convert.ToInt32(
                dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value
            );

            SqlConnection conn = SqlDB.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Orders SET Status=@s WHERE OrderID=@id",
                conn);

            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@id", orderID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadOrders();
            MessageBox.Show("Статус обновлён.");
        }

        private void LoadClientsToCombo()
        {
            SqlConnection conn = SqlDB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ClientID, FullName FROM Clients", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboClients.DataSource = dt;
            comboClients.DisplayMember = "FullName";
            comboClients.ValueMember = "ClientID";
        }

        private void LoadPropertyToCombo()
        {
            SqlConnection conn = SqlDB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PropertyID, Address FROM Property", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboProperty.DataSource = dt;
            comboProperty.DisplayMember = "Address";
            comboProperty.ValueMember = "PropertyID";
        }

        private void FormRealtor_Load(object sender, EventArgs e)
        {
            RealtorID = Session.CurrentUserID;
            LoadClients();
            LoadOrders();
            LoadClientsToCombo();
            LoadPropertyToCombo();
            TestDocs();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlDB.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Clients (FullName, Phone, Email) VALUES (@n, @p, @e)", conn);

            cmd.Parameters.AddWithValue("@n", txtClientName.Text);
            cmd.Parameters.AddWithValue("@p", txtClientPhone.Text);
            cmd.Parameters.AddWithValue("@e", txtClientEmail.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Клиент успешно создан!");
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ!");
                return;
            }

            int orderID = Convert.ToInt32(
                dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value
            );

            SqlConnection conn = SqlDB.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Documents (OrderID, DocName, CreatedBy, FilePath, Status)
                  VALUES (@o, @n, @c, @f, 'Создан')",
                conn);

            cmd.Parameters.AddWithValue("@o", orderID);
            cmd.Parameters.AddWithValue("@n", txtDocTitle.Text);
            cmd.Parameters.AddWithValue("@c", RealtorID);
            cmd.Parameters.AddWithValue("@f", txtDocPath.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Документ добавлен!");
        }

        private void btnSetAccepted_Click(object sender, EventArgs e)
        {
            SetStatus("Принят");
        }

        private void btnSetPaid_Click(object sender, EventArgs e)
        {
            SetStatus("Оплачен");
        }

        private void TestDocs()
        {
            SqlConnection conn = SqlDB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Documents", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDocs.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOrders();
            LoadClients();
            LoadClientsToCombo();
            LoadPropertyToCombo();
            TestDocs();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (comboClients.SelectedIndex == -1 || comboProperty.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите клиента и объект недвижимости!");
                return;
            }

            int clientID = Convert.ToInt32(comboClients.SelectedValue);
            int propertyID = Convert.ToInt32(comboProperty.SelectedValue);

            SqlConnection conn = SqlDB.GetConnection();

            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Orders (ClientID, EmployeeID, PropertyID, Status)
          VALUES (@c, @e, @p, 'Принят')",
                conn);

            cmd.Parameters.AddWithValue("@c", clientID);
            cmd.Parameters.AddWithValue("@e", RealtorID);
            cmd.Parameters.AddWithValue("@p", propertyID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadOrders();
            MessageBox.Show("Заказ успешно создан!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
                return;

            int orderID = Convert.ToInt32(
                dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value
            );

            LoadDocuments(orderID);
        }
    }
}
