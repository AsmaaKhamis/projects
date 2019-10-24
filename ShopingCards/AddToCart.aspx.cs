using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddToCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("productid");
            dt.Columns.Add("productname");
            dt.Columns.Add("price");
            dt.Columns.Add("productimage");
            dt.Columns.Add("cost");
            dt.Columns.Add("totalcost");
            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {
                    dr = dt.NewRow();
                    String con = "Data Source=DESKTOP-VQ4OEJT\\SQLEXPRESS;Initial Catalog=ShoppingCard;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(con);
                    String myquery = "select * from ProductDetails where productid=" + Request.QueryString["id"];
                    SqlCommand com = new SqlCommand();
                    com.CommandText = myquery;
                    com.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = com;
                    DataSet ds = new DataSet();
                    da.Fill(ds); ;
                    dr["sno"] = 1;
                    dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                    dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                    dr["productimage"] = ds.Tables[0].Rows[0]["productimge"].ToString();
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["Buyitems"] = dt;





                }
                else
                {
                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;
                    dr = dt.NewRow();
                    String con = "Data Source=DESKTOP-VQ4OEJT\\SQLEXPRESS;Initial Catalog=ShoppingCard;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(con);
                    String myquery = "select * from ProductDetails where productid=" + Request.QueryString["id"];
                    SqlCommand com = new SqlCommand();
                    com.CommandText = myquery;
                    com.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = com;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = sr + 1;
                    dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                    dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                    dr["productimage"] = ds.Tables[0].Rows[0]["productimge"].ToString();
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["buyitems"] = dt;

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

    }
}