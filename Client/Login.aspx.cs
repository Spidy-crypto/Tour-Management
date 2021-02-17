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
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security=True";
                using (con)
                {
                    string command = "INSERT INTO [Fplace](email,placeid)VALUES(@email,@placeid)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", "abdc");
                    cmd.Parameters.AddWithValue("@placeid", 5);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        Label1.Text = "lol";
                    }
                    else
                    {
                        Label1.Text = "elses";
                    }
                }
            }
            catch (Exception err)
            {
                Label1.Text = err.ToString();
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}
