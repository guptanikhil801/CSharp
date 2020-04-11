using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagementWCFClient.LoginReference;
using EmployeeManagementWCFClient.EmployeeReference;

namespace EmployeeManagementWCFClient
{
    public partial class LoginForm : System.Web.UI.Page
    {
        LoginReference.LoginClient client = new LoginReference.LoginClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
                if (client.LoginAuthentication(email,password))
                {
                    ResponseLabel.Text = "Login Successfull";
                }
            else 
                ResponseLabel.Text = "unsucessfull";
        }
    }
}