using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace TreeBuilder
{
    public class TreeBuilderDL
    {
        string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
        public DataTable ExecuteCommand(string Text, CommandType CmdType)
        {
            SqlConnection connect;
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(dbConnect);
                connect.Open();
                SqlCommand command = new SqlCommand(Text, connect);
                command.CommandType = CmdType;
                SqlDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                connect.Close();
                return dt;
            }
            catch (Exception ex)
            {
                ExceptionLogging.ExceptionLogg.SendExcepToDB(ex);
                throw;
            }
        }
    }
}