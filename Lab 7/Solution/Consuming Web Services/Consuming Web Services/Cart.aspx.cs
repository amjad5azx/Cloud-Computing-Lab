using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consuming_Web_Services
{
    public partial class Cart : System.Web.UI.Page
    {
        private localhost.AddtoCart service;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            localhost.AddtoCart client = new localhost.AddtoCart();
            string itemName = txtItemName.Text;
            string newItem = client.AddToCart(itemName);
            List<string> cartItems = new List<string>();
            if (Session["CartItems"] != null)
            {
                cartItems = (List<string>)Session["CartItems"];
            }
            cartItems.Add(newItem);
            Session["CartItems"] = cartItems;
            Label1.Text = string.Join("<br />", cartItems);
            txtItemName.Text = "";
        }
    }
}