using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            if(client.addUser("raj@gmail.com", "raj", "kalathiiya", "1234")){
                email.Text = "hehe";
            }
            else
            {
                email.Text = "haha";
            }
        }
    }
}