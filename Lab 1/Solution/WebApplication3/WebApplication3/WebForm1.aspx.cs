using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-27TFO05;Initial Catalog=Student;User ID=sa;Password=amjad");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string update = string.Format("Update Detail set stName='{0}',department='{1}',batch='{2}' where stId={3}",TextBox2.Text,TextBox3.Text,TextBox4.Text,int.Parse(TextBox1.Text));
            SqlCommand cmd = new SqlCommand(update,con);
            cmd.ExecuteNonQuery();
            Response.Redirect("WebForm1.aspx");
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete = string.Format("delete from Detail where stId={0}",Convert.ToInt32(TextBox1.Text));
            SqlCommand cmd = new SqlCommand(delete,con);
            cmd.ExecuteNonQuery();
            Response.Redirect("WebForm1.aspx");
            con.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string create = string.Format("Insert into Detail(stName,department,batch)values('{0}','{1}','{2}')", TextBox2.Text, TextBox3.Text, TextBox4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand(create, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("WebForm1.aspx");
        }
    }
}