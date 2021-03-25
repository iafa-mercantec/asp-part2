using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace part2.Pages
{
    public partial class ProductView : System.Web.UI.Page
    {
        public class MultiList : Dictionary<string, List<string>> { }
        MultiList products = new MultiList();

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Product", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    
                        var row=(IDataRecord)reader;
                        var product = row["Product"].ToString();
                        var description = row["Description"].ToString();
                        Response.Write("<script>alert('" + product + " - "+description+"');</script>");
                        /*
                        try
                        {
                            products[product].Add(description);
                            
                        }
                        catch
                        {
                            products.Add(product, new List<string>());
                            products[product].Add(description);
                        }
                        
                        DropDownList1.Items.Add(new ListItem (col["Product"].ToString()));
                        */
                        //Response.Write("<script>alert('" + col["Product"] + "');</script>");
                    }
                    /*
                    string productSelection = "Problems";
                    foreach (KeyValuePair<string, List<string>> elements in products)
                    {
                        if (elements.Key == productSelection)
                        {
                            foreach (var text in elements.Value)
                            {
                                //Response.Write("<script>alert('" + text + "');</script>");
                            }
                        }
                            
                    }
                    */
                    /*
                    products[productSelection].ForEach(delegate (String text)
                    {
                        Response.Write("<script>alert('" + text + "');</script>");
                    });
                    */
                    /*
                    foreach (KeyValue<string, List<string>> elements in products[productSelection])
                    {
                        Response.Write("<script>alert('" + elements.Key +"-"+ elements.Value + "');</script>");
                    }
                    */
                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('connection failed'+'" + er + "');</script>");
            }
            finally { conn.Close(); }
            
        }
    }
}