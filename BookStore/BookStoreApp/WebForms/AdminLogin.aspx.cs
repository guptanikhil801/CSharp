using BookStoreManager.ImplManager;
using System;

namespace BookStoreApp.WebForms
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
            if (this.mgr.AdminLogin(email, password))
            {
                Server.Transfer("AdminDashBoard.aspx");
            }

            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}