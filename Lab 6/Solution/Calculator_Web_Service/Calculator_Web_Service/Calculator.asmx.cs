using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_Web_Service
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
