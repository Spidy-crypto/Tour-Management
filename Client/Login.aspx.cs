using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            client = new ServiceReference1.Service1Client();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(client.checkUser(email.Text, password.Text))
            {
                Session["id"] = email.Text;
            }
            else
            {
                email.Text = "";
                Label1.Text = "Invalid Username or Password";
            }
        }
    }
}
