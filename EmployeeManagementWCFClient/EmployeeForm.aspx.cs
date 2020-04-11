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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                EmployeeReference.EmployeeServiceClient client = new EmployeeReference.EmployeeServiceClient();
                ds = client.GetEmployeeDetails();
                grdAllEmployees.DataSource = ds;
                grdAllEmployees.DataBind();
            }

        }

    }
}