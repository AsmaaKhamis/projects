using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        string mycon = "Data Source=DESKTOP-VQ4OEJT\\SQLEXPRESS;Initial Catalog=LastUpdate;Integrated Security=True";
        string myquery = "select * from Notification order by notifyid DESC";
        SqlConnection con = new SqlConnection(mycon);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label3.Text = ds.Tables[0].Rows[0]["message"].ToString();

        }
        con.Close();



    }
}