// -------------------------------------------------------------------------------------------------------
// <copyright file="LoginForm.aspx.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace EmployeeManagementWCFClient
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using EmployeeManagementWCFClient.EmployeeReference;
    using EmployeeManagementWCFClient.LoginReference;

    /// <summary>
    /// This class contains code for Login Web Form
    /// </summary>
    /// <seealso cref="System.Web.UI.Page" />
    public partial class LoginForm : System.Web.UI.Page
    {
        protected LoginReference.LoginClient client = new LoginReference.LoginClient();

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the Login_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
            if (this.client.LoginAuthentication(email, password))
            {
                ResponseLabel.Text = "Login Successfull";
                Server.Transfer("EmployeeForm.aspx");
            }
            else
            {
                ResponseLabel.Text = "Invalid Email and Password combination";
            }
        }
    }
}