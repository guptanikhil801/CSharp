namespace DesignPattern.Automapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AutoMapper;
   public class TestAutoMapping
    {
        public static void DriverMethod()
        {
            var config = new MapperConfiguration(cfg =>                  //// configuring mapper
            cfg.CreateMap<EmployeeHeadOffice, EmployeeBlrBranch>());
            IMapper imap = config.CreateMapper();
            EmployeeHeadOffice emph = new EmployeeHeadOffice();
            emph.FullName = "Nikhil Gupta";
            emph.Contact = 9031378339;
            emph.Address = "Btm, Bangalore";
            emph.EmpId = 007;
            emph.Department = "Developer";
            var destination = imap.Map<EmployeeHeadOffice, EmployeeBlrBranch>(emph);
            Console.WriteLine("After Mapping Data of EmpBlrBranch :");
            Console.WriteLine("Full Name :  " + destination.FullName + ",       Contact :  " + destination.Contact + ",  Address :   " + destination.Address);
            Console.WriteLine("  Emp Id :   " + destination.EmpId + ", Department  :   " + destination.Department);
        }
    }
}
