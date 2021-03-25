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
                        
                        try
                        {
                            products[product].Add(description);
                            
                        }
                        catch
                        {
                            products.Add(product, new List<string>());
                            products[product].Add(description);
                            if (!DropDownList1.Items.Contains(new ListItem(product)))
                                DropDownList1.Items.Add(product);
                        }
                    }

                    
                    string productSelection = "Problems";
                    
                    foreach (var text in products[productSelection])
                    {
                        ListBox1.Items.Add(text);
                    }

                    //Response.Write("<script>alert('" + elements.Key +"-"+ elements.Value + "');</script>");

                }
            }
            catch (Exception er)
            {
                Response.Write("<script>alert('connection failed'+'" + er + "');</script>");
            }
            finally { conn.Close(); }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productSelection = DropDownList1.SelectedItem.Value;
            //Response.Write("<script>alert('" + sender.GetType().ToString() + "');</script>");
            ListBox1.Items.Clear();
            foreach (var text in products[productSelection])
            {
                ListBox1.Items.Add(text);
            }
            
        }
    }
}