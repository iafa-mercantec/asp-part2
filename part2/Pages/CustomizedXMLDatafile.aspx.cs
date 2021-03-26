using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;

namespace part2.Pages
{
    public partial class CustomizedXMLDatafile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Category, Product, NumberInStock " +
                    "from Product p INNER JOIN Category c ON p.CategoryID = c.CategoryID", conn);

                //SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Product, NumberInStock from Product", conn);
                DataSet dataset = new DataSet();

                sqlData.Fill(dataset, "XMLData");
                dataset.WriteXml(Server.MapPath("XMLFil.xml"));

            }
            catch (Exception er)
            {
                Response.Write("<script>alert('connection failed'+'" + er + "');</script>");
            }
            finally { conn.Close(); Bindchart(); }
        }

        //private Color FromRgbExample()
        //{
        //    Random rnd = new Random();
        //    Color myRgbColor = new Color();
        //    myRgbColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        //    return myRgbColor;
        //}

        private void Bindchart()
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(MapPath("~/Pages/XMLFil.xml"));

            DataTable ChartData = dataset.Tables[0];

            string[] XPointMember = new string[ChartData.Rows.Count];
            int[] YPointMember = new int[ChartData.Rows.Count];


            for (int count = 0; count < ChartData.Rows.Count; count++)
            {
                int nr = 0;

                XPointMember[count] = (string)ChartData.Rows[count]["Category"];

                for (int count2 = 0; count2 < ChartData.Rows.Count; count2++)
                {
                    if((string)ChartData.Rows[count2]["Category"] == XPointMember[count])
                    {
                        nr++;
                    }
                }

                YPointMember[count] = nr*100/2;
            }

            Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

            Chart1.Series[0].BorderWidth = 10; 
            Chart1.Series[0].ChartType = SeriesChartType.Pie;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

            //int i = 20;

            foreach (Series charts in Chart1.Series)
            {
                foreach (DataPoint point in charts.Points)
                {
                    //point.Color = Color.FromArgb(i*10, i*10, i*10);
                    //Response.Write("<script>alert('color: '+'" + myRgbColor + "');</script>");

                    switch (point.AxisLabel)
                    {
                        case "Stuff": point.Color = Color.RoyalBlue; break;
                        case "sko": point.Color = Color.SaddleBrown; break;
                    }
                    point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);
                    //i++;
                }
            }
        }
    }
}