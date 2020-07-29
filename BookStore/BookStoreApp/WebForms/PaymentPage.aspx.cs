﻿using BookStoreManager.ImplManager;
using System;

namespace BookStoreApp.WebForms
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        private CustomerMgr customerManager = new CustomerMgr();
        private CartMgr cartmanager = new CartMgr();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Success_Message(object sender, EventArgs e)
        {
            Random _random = new Random();
            var randomnumber = _random.Next(10000, 99999);
            string msg =
         "<div class='card selectpaymentdiv'>" +
               "<h1 class='card-header text-center text-primary '>" + "Your order has been placed" + "</h1>" +
                "<h4 class='text-left ml-3 mt-3'>Your Order Number is " + randomnumber + "</h4>" +
                "<p class='ml-3 m-md-4'>Thanks For Shopping</p>" +
         "</div>";
            maindiv.Attributes.CssStyle.Clear();
            maindiv.InnerHtml = msg;
        }

        protected void ShowAdd(object sender, EventArgs e)
        {
            string email = emailid.Value.ToString();
            AddressDetails(email);
            homeaddradio.Checked = true;
        }

        private void AddressDetails(string email)
        {
            var customer = customerManager.CustomerDetails(email);
            var fullname = customer.FirstName + " " + customer.LastName;
            CustomerName.Value = fullname;
            CustomerPhone.Value = customer.PhoneNumber.ToString();
            CustomerAddress.Value = customer.Address;
            CustomerCity.Value = customer.City;
            CustomerPin.Value = customer.PinCode.ToString();
        }

        protected void PayDetails(object sender, EventArgs e)
        {
            string email = emailid.Value.ToString();
            addresssection.InnerHtml = string.Empty;
            Response.Write("<script language=javascript> function removeamount(){ localStorage.removeitem('totalamount');} removeamount();</script>");
            maindiv.Attributes.CssStyle.Clear();
        }
    }
}