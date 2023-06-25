using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using TwoFactorAuthentication.Models;

namespace TwoFactorAuthentication.Controllers
{
    public class SignUpController : Controller
    {
        private readonly string _googleAuthKey;

        public SignUpController()
        {
            _googleAuthKey = WebConfigurationManager.AppSettings["GoogleAuthKey"];
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                string connectionString = "Data Source=DESKTOP-27TFO05;Initial Catalog=UserData;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = String.Format("INSERT INTO users (Firstname, Lastname, Email, Username, Password) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        user.Firstname, user.Lastname, user.Email, user.Username, user.Password);
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                return RedirectToAction("Welcome", new { fullName = $"{user.Firstname} {user.Lastname}" });
            }

            return View(user);
        }

        public ActionResult Welcome(string fullName)
        {
            ViewBag.FullName = fullName;
            ViewBag.GoogleAuthKey = _googleAuthKey;
            return View();
        }
    }

}