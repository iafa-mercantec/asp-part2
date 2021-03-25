using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace part2
{
     public partial class index : System.Web.UI.Page
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
                Response.Write("<script>alert('connection failed'+'"+er+"');</script>");
            }
            finally { conn.Close();}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string userid = TextBox1.Text;
            string password = TextBox2.Text;
            SqlCommand cmd = new SqlCommand("select FirstName,Password from Customer where FirstName='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) // using (SqlDataReader reader = cmd.ExecuteReader())
            {
                //Response.Write("<script>alert('"+ reader["FirstName"] + "');</script>");
                Response.Redirect("~/Pages/ProductView.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Login please check username and password');</script>");
            }
            conn.Close();
        }
    }
}