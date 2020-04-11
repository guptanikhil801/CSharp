// -------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeForm.aspx.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------s

namespace EmployeeManagementWCFClient
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using EmployeeManagementWCFClient.EmployeeReference;
    using EmployeeManagementWCFClient.LoginReference;

    /// <summary>
    /// this class contains code for page load and events
    /// </summary>
    /// <seealso cref="System.Web.UI.Page" />
    public partial class EmployeeForm : System.Web.UI.Page
    {
      protected EmployeeReference.EmployeeServiceClient client = new EmployeeReference.EmployeeServiceClient();

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                ds = this.client.GetEmployeeDetails();
                grdAllEmployees.DataSource = ds;
                grdAllEmployees.DataBind();
            }
        }

        /// <summary>
        /// this method contains code when Add Button will be clicked
        /// </summary>
        /// <param name="sender"> the object</param>
        /// <param name="e">the EventArgs</param>
        protected void Add_Button_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = FirstNameTextBox.Text.ToString();
            employee.LastName = LastNameTextBox.Text.ToString();
            employee.Email = EmailTextBox.Text.ToString();
            employee.Password = PasswordTextBox.Text.ToString();
            employee.DeptId = Convert.ToInt32(DeptIdTextBox.Text.ToString());
            ResponseLabel.Text = this.client.AddEmployee(employee);
        }

        /// <summary>
        /// this method contains code when Update Button will be clicked
        /// </summary>
        /// <param name="sender">The object</param>
        /// <param name="e">The EventArgs</param>
        protected void Update_Button_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmpId = Convert.ToInt32(EmployeeIDTextBox.Text.ToString());
            employee.FirstName = FirstNameTextBox.Text.ToString();
            employee.LastName = LastNameTextBox.Text.ToString();
            employee.Email = EmailTextBox.Text.ToString();
            employee.Password = PasswordTextBox.Text.ToString();
            employee.DeptId = Convert.ToInt32(DeptIdTextBox.Text.ToString());
            ResponseLabel.Text = this.client.UpdateEmployee(employee);
        }

        /// <summary>
        /// this method contains code when delete Button will be clicked
        /// </summary>
        /// <param name="sender">The Object</param>
        /// <param name="e">the EventArgs</param>
        protected void Delete_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EmpTextBox.Text.ToString());
            ResponseLabel.Text = this.client.DeleteEmployee(id);
        }

        /// <summary>
        /// this method contains code when delete Button will be clicked
        /// </summary>
        /// <param name="sender">The Object</param>
        /// <param name="e">the EventArgs</param>
        protected void EmployeeById_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EmpTextBox.Text.ToString());
            DataSet ds = new DataSet();
            ds = this.client.EmployeeDetailsById(id);
            grdAllEmployees.DataSource = ds;
            grdAllEmployees.DataBind();
        }
    }
}