using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consuming_Web_Services
{
    public partial class Calculator : System.Web.UI.Page
    {
        CalculatorWebService.Calculator calculator = new CalculatorWebService.Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            res.Text = "Result: " + calculator.Add(a, b).ToString();
            num1.Text = "";
            num2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            res.Text = "Result: "+calculator.Subtract(a, b).ToString();
            num1.Text = "";
            num2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            res.Text = "Result: " + calculator.Multiply(a, b).ToString();
            num1.Text = "";
            num2.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            res.Text = "Result: " + calculator.Divide(a, b).ToString();
            num1.Text = "";
            num2.Text = "";
        }
    }
}