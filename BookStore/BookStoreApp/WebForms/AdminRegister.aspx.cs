using BookStoreManager.ImplManager;
using System;

namespace BookStoreApp.WebForms
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        protected AdminMgr mgr = new AdminMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_Up_Button(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
            if (this.mgr.AdminRegistration(email, password))
            {
                Server.Transfer("Adminlogin.aspx");
            }

            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}