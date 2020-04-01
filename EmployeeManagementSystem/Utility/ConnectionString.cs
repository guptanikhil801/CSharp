using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Utility
{
    public class ConnectionString
    {
        private static string cName = "Data Source=.; Initial Catalog=EmployeeManagement;Integrated Security=true";
        public static string CName
        {
            get => cName;
        }
    }
}