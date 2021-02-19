﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class AddTour : System.Web.UI.Page
    {
        ServiceReference2.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference2.Service1Client();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imagefile = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(@"C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\images\" + imagefile);

            if (client.addPlace(name.Value, description.Value, price.Value, imagefile))
            {
                name.Value = "Added";
            }
            else
            {
                name.Value = "not added";
            }

        }
    }
}