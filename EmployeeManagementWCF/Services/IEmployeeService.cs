using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeManagementWCF.Services
{
    [ServiceContract]
    public interface IEmployeeService
    {
                
    }

    [DataContract]
public class Employee
    {
        [DataMember]
        public int EmpId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int DeptId { get; set; }
    }
}

