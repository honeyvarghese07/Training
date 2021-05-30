using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLogic
{
    public class DataAccess
    {
        static SqlConnection connect;
        private static void Connection()
        {
            string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
            connect = new SqlConnection(dbConnect);
            connect.Open();
        }
        public DataTable LoginUser(string emailid, string password)
        {
            Connection();
            DataTable dt = null;
            string query = "select * from users where emailid='" + emailid + "'and password='" + password + "' and isDeleted= 1 and isActive=1";
            SqlCommand command = new SqlCommand(query, connect);
            command.Connection = connect;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dt = ds.Tables[0];
            return (dt);

        }

        public int CreateUser(string fname, string lname, string emailid, string phone, string gender, DateTime dob, string address, string country, string password)
        {
            Connection();
            string query = "insert into users(fname,lname,emailid,phone,gender,dob,address,country,password)" +
                "values('" + fname + "','" + lname + "','" + emailid + "','" + phone + "','" + gender + "'," +
                "'" + dob + "','" + address + "','" + country + "','" + password + "')";
            SqlCommand command = new SqlCommand(query, connect);
            command.Connection = connect;
            command.ExecuteNonQuery();
            return 1;
        }
    }
}