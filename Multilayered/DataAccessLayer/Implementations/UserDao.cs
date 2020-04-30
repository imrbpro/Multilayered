using DataAccessLayer.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class UserDao : IUserDao
    {
        private string conString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        private SqlConnection con;
        private SqlCommand sc;
        private SqlDataReader reader;
        public UserDao()
        {
            con = new SqlConnection(conString);
        }
        public bool AddUser(User user)
        {
            try
            {
                con.Open();
                sc = new SqlCommand("insert into tUser(UserName,Password,FirstName,LastName,Hobby,isActive) Values('" + user.UserName+"','"+user.Password+"','"+user.FirstName+"','"+user.LastName+"','"+user.Hobby+"',1)", con);
                if(sc.ExecuteNonQuery() > 0)
                {

                    con.Close();
                    return true;
                }
                else
                {

                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                con.Open();
                sc = new SqlCommand("Delete tUser where UserId = "+id+"", con);
                if (sc.ExecuteNonQuery() > 0)
                {

                    con.Close();
                    return true;
                }
                else
                {

                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetAllUsers()
        {
            try
            {
                DataTable ds = new DataTable();
                con.Open();
                sc = new SqlCommand("select * from tUser", con);
                reader = sc.ExecuteReader();
                ds.Load(reader);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                con.Open();
                sc = new SqlCommand("Update tUser Set(UserName = '" + user.UserName + "',Password='" + user.Password + "',FirstName='" + user.FirstName + "',LastName ='" + user.LastName + "',Hobby='" + user.Hobby + "',isActive=" + user.isActive + ") Where UserId = "+user.UserId+"", con);
                if (sc.ExecuteNonQuery() > 0)
                {

                    con.Close();
                    return true;
                }
                else
                {

                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
