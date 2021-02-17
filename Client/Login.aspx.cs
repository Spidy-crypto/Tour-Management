﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            client = new ServiceReference1.Service1Client();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (client.checkUser(username.Value, password.Value))
            {
                Session["current_user"] = username.Value;
                Response.Redirect("Registration.aspx");
            }
            else
            {
                Response.Write("jo bhai");
            }
            /*if (FileUpload1.PostedFile != null)
            {
                string imagefile = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(@"C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\images\" + imagefile);
            }*/
        }
    }
}
