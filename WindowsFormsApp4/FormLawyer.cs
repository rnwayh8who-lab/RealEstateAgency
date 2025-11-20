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
    public partial class FormLawyer : Form
    {
        int LawyerID;
        public FormLawyer()
        {
            InitializeComponent();
            LawyerID = Session.CurrentUserID;
        }

        private void LoadDocuments()
        {
            SqlConnection conn = SqlDB.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Documents.DocumentID,
                         Clients.FullName AS Client,
                         Property.Address AS Property,
                         Documents.DocName,
                         Documents.FilePath,
                         Documents.Status,
                         Orders.OrderID,
                         Employees.FullName AS CreatedBy
                  FROM Documents
                  JOIN Orders ON Documents.OrderID = Orders.OrderID
                  JOIN Clients ON Orders.ClientID = Clients.ClientID
                  JOIN Property ON Orders.PropertyID = Property.PropertyID
                  JOIN Employees ON Documents.CreatedBy = Employees.EmployeeID
                  WHERE Employees.Role = 'Realtor'",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewDocs.DataSource = dt;
        }

        private void LoadOrders()
        {
            SqlConnection conn = SqlDB.GetConnection();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Orders.OrderID,
                 Clients.FullName AS Client,
                 Property.Address AS Property,
                 Orders.Status,
                 Orders.CreatedDate,
                 Employees.FullName AS Realtor
          FROM Orders
          JOIN Clients ON Orders.ClientID = Clients.ClientID
          JOIN Property ON Orders.PropertyID = Property.PropertyID
          JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
          ORDER BY Orders.OrderID DESC",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewOrders.DataSource = dt;
        }

        private void SetOrderStatus(string status)
        {
            if (dataGridViewDocs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите документ!");
                return;
            }

            int orderID = Convert.ToInt32(
                dataGridViewDocs.SelectedRows[0].Cells["OrderID"].Value
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

            LoadDocuments();
            MessageBox.Show("Статус заказа изменён.");
        }

        private void FormLawyer_Load(object sender, EventArgs e)
        {
            LoadDocuments();
            LoadOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDocuments();
            LoadOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
