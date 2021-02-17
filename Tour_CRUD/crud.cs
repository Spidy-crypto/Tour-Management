using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tour_CRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class crud : IService1
    {
        public bool addPlace(string name, string desc, string price, string imagepath)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "INSERT INTO [Place](name,description,price,imagepath)VALUES(@name,@description,@price,@imagepath)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", "paras");
                    cmd.Parameters.AddWithValue("@description", "sd");
                    cmd.Parameters.AddWithValue("@price", "rice");
                    cmd.Parameters.AddWithValue("@imagepath", "sd");
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

        public bool addToFav(String email, int placeid)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "INSERT INTO [Fplace](email,placeid)VALUES(@email,@placeid)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@placeid", placeid);
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

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<tour> getAllPlace()
        {
            List<tour> users = new List<tour>();
            tour u;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from Place";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        u = new tour();
                        u.name = rdr["name"].ToString();
                        u.desc = rdr["desc"].ToString();
                        u.price = rdr["price"].ToString();
                        u.imagepath = rdr["imagepath"].ToString();
                        users.Add(u);
                    }
                    rdr.Close();
                    return users;
                }
            }
            catch (Exception err)
            {
                return users;
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

        public tour getPlace(int id)
        {
            tour u = new tour();
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from Place where id = '" + id + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        u.name = rdr["name"].ToString();
                        u.desc = rdr["desc"].ToString();
                        u.price = rdr["price"].ToString();
                        u.imagepath = rdr["imagepath"].ToString();

                    }
                    rdr.Close();
                    return u;
                }
            }
            catch (Exception err)
            {
                return u;
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

        public bool updatePlace(int id,String name,String description,String price,String imagepath)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\rajka\OneDrive\Documents\GitHub\Tour-Management\Client\App_Data\Database.mdf;Integrated Security = True";

                using (con)
                {
                    string command = "UPDATE Place set name = @name, description = @description, price = @price, imagepath = @imagepath where id='" + id + "' ";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.Add("@name", name);
                    cmd.Parameters.Add("@description", description);
                    cmd.Parameters.Add("@price", price);
                    cmd.Parameters.Add("@imagepath", imagepath);
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
    }
}
