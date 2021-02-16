using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TourService
{
    public class Service1 : IService1
    {
        public bool addUser(string email, string fname, string lname, string password)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "INSERT INTO users(email,fname,lname,password)VALUES(@email,@fname,@lname,@password)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@password", password);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;    
                    }
                }
            }
            catch (Exception err)
            {
                return false;
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

        public bool checkUser(string email,string password)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from users where email = '" + email + "' and password = '" + password + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                return false;
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

        public bool getSingleUser(string email)
        {
            return true;
        }


    }
}
