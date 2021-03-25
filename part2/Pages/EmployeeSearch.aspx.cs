using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace part2.Pages
{
    public partial class EmployeeSearch : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('connection failed'+'" + er + "');</script>");
            }
            finally { conn.Close(); }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            conn.Open();

            string searchStr = TextBox1.Text;
            SqlCommand cmd = new SqlCommand("select FirstName, LastName, EmailAddress, Phone from Employee where FirstName LIKE '%" + searchStr + "%' OR LastName LIKE '%" + searchStr + "%'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();

                cell1.Text = (string)reader.GetValue(0) + " " + (string)reader.GetValue(1);
                cell2.Text = (string)reader.GetValue(2);
                cell3.Text = (string)reader.GetValue(3);

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);

                Table1.Rows.Add(row);
            }

            conn.Close();
        }
    }
}