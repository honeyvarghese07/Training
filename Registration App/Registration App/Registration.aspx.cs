using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using DataAccessLogic;

namespace Registration_App
{
    public partial class Register : System.Web.UI.Page
    {
        Boolean error = false;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void RegisterClick(object sender, EventArgs e)
        {
            ValidateText();
            ValidateEmail();
            ValidatePhone();
            ValidatePassword();

            if (this.error == false)
            {
                try
                {
                    DataAccess insert = new DataAccess();
                    DateTime Dob = DateTime.Parse(dob.Text);
                    string Password = Encrypt.EncryptPassword(password.Text);
                    insert.CreateUser(fname.Text, lname.Text, emailid.Text, phone.Text, gender.SelectedValue, Dob, address.Text, country.SelectedValue, Password);
                    HttpContext.Current.Response.Write("<script> alert('Registration Successfull!');</script>");
                    Server.Transfer("LoginPage.aspx",false);
                    
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception ex)
                {
                    ExceptionLogging.ExceptionLogg.SendExcepToDB(ex);
                    ExceptionToText.ExceptionToText.SendErrorToText(ex);
                    HttpContext.Current.Response.Write("<script> alert('Something went wrong!');</script>");
                }
            }
            else
            {
                Response.Write("<script> alert('Registration Unsuccessfull!');</script>");
            }
            
        }

        protected void ValidateText()
        {
            var Fname = fname.Text;
            var Lname = lname.Text;
            if (Fname == "")
            {
                message.Text = "First Name is Empty";
                this.error = true;
            }
            if (Lname == "")
            {
                message2.Text = "Last Name is Empty";
                this.error = true;
            }
        }

        protected void ValidateEmail()
        {
            string Email = emailid.Text;
            Regex reg_email = new Regex(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$");
            Match match = reg_email.Match(Email);
            if (match.Success)
            {
                message3.Text = "";
            }
            else
            {
                message3.Text = "Invalid Email";
                this.error = true;
            }
        }
        protected void ValidatePassword()
        {
            string Password = password.Text;
            Regex regex = new Regex(@"[a-zA-Z0-9!@#$%^&*]$");
            Match match = regex.Match(Password);
            if (match.Success)
            {
                message6.Text = "";
            }
            else
            {
                message6.Text = "Password must contain atleast 8 letters, one number and one special character";
                this.error = true;
            }
        }
        protected void ValidatePhone()
        {
            string phoneno = phone.Text;
            Regex regex = new Regex(@"^\d{10}$");
            Match match = regex.Match(phoneno);
            if (match.Success)
            {
                message4.Text = "";

            }
            else
            {
                message4.Text = "Invaild Phone Number";
                this.error = true;
            }
        }
        public void ValidateDate()
        {
            DateTime Dob = DateTime.Parse(dob.Text);
            string DOB = Dob.ToString();
            int selectedDate= DOB.
        }

    }
}
