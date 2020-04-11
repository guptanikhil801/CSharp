using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagementWCFClient.LoginReference;
using EmployeeManagementWCFClient.EmployeeReference;
namespace EmployeeManagementWCFClient
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        EmployeeReference.EmployeeServiceClient client = new EmployeeReference.EmployeeServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                ds = client.GetEmployeeDetails();
                grdAllEmployees.DataSource = ds;
                grdAllEmployees.DataBind();
            }
        }
        protected void Add_Button_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = FirstNameTextBox.Text.ToString();
            employee.LastName = LastNameTextBox.Text.ToString();
            employee.Email = EmailTextBox.Text.ToString();
            employee.Password = PasswordTextBox.Text.ToString();
            employee.DeptId = Convert.ToInt32(DeptIdTextBox.Text.ToString());
            ResponseLabel.Text = client.AddEmployee(employee);
        }
        protected void Update_Button_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmpId = Convert.ToInt32(EmployeeIDTextBox.Text.ToString());
            employee.FirstName = FirstNameTextBox.Text.ToString();
            employee.LastName = LastNameTextBox.Text.ToString();
            employee.Email = EmailTextBox.Text.ToString();
            employee.Password = PasswordTextBox.Text.ToString();
            employee.DeptId = Convert.ToInt32(DeptIdTextBox.Text.ToString());
            ResponseLabel.Text = client.UpdateEmployee(employee);
        }
        protected void Delete_Button_Click(object sender, EventArgs e)
        {
          int id = int.Parse(EmpTextBox.Text.ToString());
          ResponseLabel.Text = client.DeleteEmployee(id);
        }
        protected void EmployeeById_Button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EmpTextBox.Text.ToString());
            DataSet ds = new DataSet();
            ds = client.EmployeeDetailsById(id);
            grdAllEmployees.DataSource = ds;
            grdAllEmployees.DataBind();
        }
        
    }
}