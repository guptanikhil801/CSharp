using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;

namespace BookStoreApp.WebForms
{
    public partial class Registration : System.Web.UI.Page
    {
        protected CustomerMgr mgr = new CustomerMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_Up_Button(object sender, EventArgs e)
        {

            RegistrationModal customer = new RegistrationModal();
            customer.FirstName = FirstNameTextBox.Text.ToString();
            customer.LastName = LastNameTextBox.Text.ToString();
            customer.Email = EmailTextBox.Text.ToString();
            customer.Password = PasswordTextBox.Text.ToString();
            customer.PhoneNumber = Convert.ToInt64(MobileTextBox.Text.ToString());
            if (this.mgr.Registration(customer))
            {
                Server.Transfer("Login.aspx");
            }

            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}