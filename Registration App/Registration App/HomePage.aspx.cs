using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Registration_App
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        
        public void ActiveUsers(object sender, EventArgs e)
        {
            string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
            SqlConnection connection = new SqlConnection(dbConnect);
            connection.Open();
            string query = "select fname,lname,emailid from users where IsActive=1";
            SqlCommand selectCommand = new SqlCommand(query, connection);
            selectCommand.Connection = connection;
            SqlDataReader reader = selectCommand.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();

        }
        public void DeletedUsers(object sender, EventArgs e)
        {
            string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
            SqlConnection connection = new SqlConnection(dbConnect);
            connection.Open();
            string query = "select fname,lname,emailid from users where IsDeleted=0";
            SqlCommand selectCommand = new SqlCommand(query, connection);
            selectCommand.Connection = connection;
            SqlDataReader reader = selectCommand.ExecuteReader();
            gridview2.DataSource = reader;
            gridview2.DataBind();

        }
        public void InactiveUsers(object sender, EventArgs e)
        {
            string dbConnect = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
            SqlConnection connection = new SqlConnection(dbConnect);
            connection.Open();
            string query = "select fname,lname,emailid from users where IsActive=0";
            SqlCommand selectCommand = new SqlCommand(query, connection);
            selectCommand.Connection = connection;
            SqlDataReader reader = selectCommand.ExecuteReader();
            gridview3.DataSource = reader;
            gridview3.DataBind();

        }

    }
}