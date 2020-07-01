using BookStoreManager.ImplManager;
using System;

namespace BookStoreApp.WebForms
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected CustomerMgr mgr = new CustomerMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link_Button(object sender, EventArgs e)
        {

            // string Email = EmailTextBox.Text.ToString();
            if (this.mgr.ForgotPassword(EmailTextBoxfp.Text.ToString()))
            {
                ResponseLabel.Text = "Check your Email a Link has been sent to reset password";
            }
            else
            {
                ResponseLabel.Text = "Something went wrong";
            }
        }
    }
}