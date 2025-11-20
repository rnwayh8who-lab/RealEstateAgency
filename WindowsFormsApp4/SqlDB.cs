using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public class SqlDB
    {
        private string connStr =
        "Data Source=YARIE;Initial Catalog=RealEstateAgency;Integrated Security=True";

        public List<int> rows = new List<int>();

        DataSet ds = new DataSet();
        private string table = "Employees";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source=.;Initial Catalog=RealEstateAgency;Integrated Security=True"
            );
        }

        public void showTable(DataGridView grid, string filter = "")
        {
            try
            {
                ds.Clear();
                grid.DataSource = null;
                grid.Refresh();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + table, conn);
                    da.Fill(ds);

                    BindingSource bs = new BindingSource();
                    bs.DataSource = ds.Tables[0];

                    if (filter != "")
                        bs.Filter = filter;

                    grid.DataSource = bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void saveTable(DataGridView grid)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    int colCount = grid.ColumnCount;
                    grid.Columns["EmployeeID"].ReadOnly = true;

                    foreach (int rowIndex in rows)
                    {
                        string id = grid.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();

                        for (int c = 1; c < colCount; c++)
                        {
                            string col = grid.Columns[c].Name;
                            string val = grid.Rows[rowIndex].Cells[c].Value?.ToString() ?? "";

                            cmd.CommandText =
                                $"UPDATE {table} SET {col}=@v WHERE EmployeeID=@id";

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@v", val);
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    rows.Clear();
                    MessageBox.Show("Изменения сохранены!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void searchInTable(DataGridView grid, string text)
        {
            string filter =
                $"FullName LIKE '%{text}%' OR " +
                $"Login LIKE '%{text}%' OR " +
                $"Role LIKE '%{text}%' OR " +
                $"Status LIKE '%{text}%' OR " +
                $"Phone LIKE '%{text}%'";

            showTable(grid, filter);
        }
    }
}
