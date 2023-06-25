using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consuming_Web_Services
{
    public partial class AgeCalculation : System.Web.UI.Page
    {
        AgeCalculationWebService.AgeCalculation ageCalculation = new AgeCalculationWebService.AgeCalculation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(TextBox1.Text);
            int month= int.Parse(TextBox2.Text);
            int day = int.Parse(TextBox3.Text);
            res.Text = "Your age is " + ageCalculation.CalculateAge(year, month, day);
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = "";
        }
    }
}