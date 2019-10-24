using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

public partial class AddNotification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    //    try
    //    {
        string query = "Insert into Notification(message,notifyid)Values('" + TextBox1.Text + "','"+TextBox2.Text+"')";
            string mycon = "Data Source=DESKTOP-VQ4OEJT\\SQLEXPRESS;Initial Catalog=LastUpdate;Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label2.Text = "Notification Sent";
            TextBox1.Text = "";
        //}
        //catch (System.Data.SqlClient.SqlException sqlException)
        //{
        //    System.Windows.Forms.MessageBox.Show(sqlException.Message);
        //    // Response.Redirect(sqlException);
        //}
        //}
       // catch (Exception ex)
       // {
            //Response.Redirect(ex.Message);
       // }
       // try
           // {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQ4OEJT\\SQLEXPRESS;Initial Catalog=LastUpdate;Integrated Security=True");

       // con.Open();
        //SqlCommand cmd = new SqlCommand("insert into Notification values('" + TextBox1.Text + "')", con);
        //cmd.ExecuteNonQuery();
       // con.Close();
       // Label2.Text = "Notification sent";
        //TextBox1.Text = "";
           // }
       // catch (System.Data.SqlClient.SqlException sqlException)
       // {
            //System.Windows.Forms.MessageBox.Show(sqlException.Message);
           // Response.Redirect(sqlException);
       // }
    }

    }

