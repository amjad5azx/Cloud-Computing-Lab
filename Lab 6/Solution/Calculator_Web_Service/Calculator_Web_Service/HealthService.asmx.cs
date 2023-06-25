using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_Web_Service
{
    /// <summary>
    /// Summary description for HealthService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HealthService : System.Web.Services.WebService
    {

        [WebMethod]
        public double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }
        [WebMethod]
        public string CaloriesBurner(string gender,double weight,double height,int age)
        {
            double calories = (10 * weight) + (6.25 * height) - (5 * age);
            if (gender.ToLower() == "male")
            {
                return "" + (calories + 5);
            }
            if (gender.ToLower() == "female")
            {
                return "" + (calories - 161);
            }
            return "Invalid info";
        }
    }
}
