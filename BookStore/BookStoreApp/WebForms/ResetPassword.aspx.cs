using BookStoreManager.ImplManager;
using System;

namespace BookStoreApp.WebForms
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected CustomerMgr mgr = new CustomerMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reset_Button(object sender, EventArgs e)
        {
            string Email = EmailTextBox.Text.ToString();
            string Password = PasswordTextBox.Text.ToString();
            if (Email != null && Password != null)
            {
                if (this.mgr.ResetPassword(Email, Password))
                {
                    ResponseLabel.Text = "New password set successfully";
                }
            }
            else
            {
                ResponseLabel.Text = "Something went wrong";
            }
        }
    }
}