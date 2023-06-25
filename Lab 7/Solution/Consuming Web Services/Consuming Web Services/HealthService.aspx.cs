using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consuming_Web_Services
{
    public partial class HealthService : System.Web.UI.Page
    {
        HealthWebService.HealthService health = new HealthWebService.HealthService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double w = double.Parse(TextBox1.Text);
            double h = double.Parse(TextBox2.Text);
            res1.Text="Your BMI is "+health.CalculateBMI(w,h);
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string gender = DropDownList1.Text;
            double w = double.Parse(TextBox3.Text);
            double h = double.Parse(TextBox4.Text);
            int age  = int.Parse(TextBox5.Text);
            res2.Text = "Calories burn is " + health.CaloriesBurner(gender, w, h, age);
            TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = "";
        }
    }
}