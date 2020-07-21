using BookStoreManager.ImplManager;
using BookStoreModal.Modals;
using System;

namespace BookStoreApp.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected CustomerMgr mgr = new CustomerMgr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button(object sender, EventArgs e)
        {

            LoginModal login = new LoginModal();
            login.Email = EmailTextBox.Text.ToString();
            login.Password = PasswordTextBox.Text.ToString();
            if (this.mgr.Login(login))
            {
                Response.Write("<script language=javascript> function setemail(email){ localStorage.setItem('useremail',email);} setemail('" + login.Email + "');</script>");
                Server.Transfer("HomePage.aspx");
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }

    }
}