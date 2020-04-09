using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementWCF
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool LoginAuthentication(String email, string password);
    }
 
}
