using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Registration_App
{
    public partial class Login: System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        public void ButtonClick(object sender, EventArgs e)
        {
            string Password = Encrypt.EncryptPassword(password.Text);
            bool result = IsValidUser(email.Text, Password);
            if (result == true)
            {
                message1.Text = "Successfully Logged in!";
                Response.Redirect("HomePage.aspx");
            }
            else
                message1.Text = "Invalid Login";
        }
        public bool IsValidUser(string emailid, string password)
        {
            DataTable dt;
            DataAccess.LoginData dbl = new DataAccess.LoginData();
            dt = dbl.LoginUser(emailid, password);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
        
}
