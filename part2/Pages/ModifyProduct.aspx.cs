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
    public partial class ModifyProduct : System.Web.UI.Page
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Product where ProductID = " + TextBox1.Text + ";", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> categoryList, supplierList;
            int categoryID = 0; 
            int supplierID = 0;

            while (reader.Read())
            {
                TextBox2.Text = (string)reader.GetValue(3);
                TextBox3.Text = (string)reader.GetValue(4);
                TextBox4.Text = (string)reader.GetValue(5);
                TextBox5.Text = reader.GetValue(6).ToString();
                TextBox6.Text = reader.GetValue(7).ToString();
                TextBox7.Text = (string)reader.GetValue(8).ToString();
                TextBox8.Text = (string)reader.GetValue(9).ToString();

                categoryID = (int)reader.GetValue(1);
                supplierID = (int)reader.GetValue(2);
            }

            conn.Close();

            categoryList = GetDropDownValues("SELECT * from Category ORDER BY(CASE CategoryID WHEN " + categoryID + " THEN 1 END) DESC;");
            supplierList = GetDropDownValues("SELECT * from Supplier ORDER BY(CASE SupplierID WHEN " + supplierID + " THEN 1 END) DESC;");

            foreach (var item in categoryList)
            {
                DropDownList1.Items.Add(new ListItem(item));
            }

            foreach (var item in supplierList)
            {
                DropDownList2.Items.Add(new ListItem(item));
            }

        }

        private List<string> GetDropDownValues(string query)
        {
            List<string> result = new List<string>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add((string)reader.GetValue(1));
            }

            conn.Close();

            return result;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            conn.Open();

            float result = float.Parse(TextBox5.Text);
            byte aaa = Convert.ToByte(TextBox6.Text);
            byte bbb = Convert.ToByte(TextBox7.Text);
            byte ccc = Convert.ToByte(TextBox8.Text);
            int ddd = Convert.ToInt32(TextBox1.Text);

            SqlCommand cmd = new SqlCommand("UPDATE Product SET " +
                "CategoryID = (SELECT CategoryID from Category WHERE Category = '" + DropDownList1.SelectedItem.Text + "'), " +
                "SupplierID = (SELECT SupplierID from Supplier WHERE Supplier = '" + DropDownList2.SelectedItem.Text + "'), " +
                "Product = '" + TextBox2.Text + "',  Description = '" + TextBox3.Text + "', Image = '" + TextBox4.Text + "', " +
                "Price = " + result + ", NumberInStock = " + aaa + ", NumberOnOrder = " + bbb + ", ReorderLevel = " + ccc + "" +
                "WHERE ProductID = " + ddd + ";", conn);

            int a = cmd.ExecuteNonQuery();

            if (a > 0) Label11.Text = Label11.Text + " Product successfully modified.";
            else Label11.Text = Label11.Text + " Product failed to be modified.";

            conn.Close();



        }
    }
}