using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part2.Pages
{
    public partial class XMLDatafile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from Employee", conn);
                DataSet dataset = new DataSet();

                sqlData.Fill(dataset, "Employee");
                dataset.WriteXml(Server.MapPath("XMLFil.xml"));

                dataset = new DataSet();
                dataset.ReadXml(MapPath("~/Pages/XMLFil.xml"));
                GridView1.DataSource = dataset;
                GridView1.DataBind();
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('connection failed'+'" + er + "');</script>");
            }
            finally { conn.Close(); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/XMLFil.xml");
        }
    }
}