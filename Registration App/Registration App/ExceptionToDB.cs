using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace ExceptionLogging
{
    public class ExceptionLogg
    {
        private static String exepurl;
        static SqlConnection connect;
        private static void Connection()
        {
            string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
            connect = new SqlConnection(dbConnect);
            connect.Open();
        }
        public static void SendExcepToDB(Exception exdb)
        {
            Connection();
            exepurl = HttpContext.Current.Request.Url.ToString();
            SqlCommand com = new SqlCommand("ExceptionLoggingToDataBase", connect);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@exceptionmsg", exdb.Message.ToString());
            com.Parameters.AddWithValue("@exceptiontype", exdb.GetType().Name.ToString());
            com.Parameters.AddWithValue("@exceptionurl", exepurl);
            com.Parameters.AddWithValue("@exceptionsource", exdb.StackTrace.ToString());
            com.ExecuteNonQuery();
        }
    }
}
