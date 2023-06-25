using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator_Web_Service
{
    /// <summary>
    /// Summary description for AgeCalculation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AgeCalculation : System.Web.Services.WebService
    {

        [WebMethod]
        public int CalculateAge(int year,int month,int day)
        {
            DateTime dt = new DateTime(year, month, day);
            int age = DateTime.Now.Year - dt.Year+1;
            if (DateTime.Now.DayOfYear > dt.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
