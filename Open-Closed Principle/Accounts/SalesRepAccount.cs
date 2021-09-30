using Open_Closed_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class SalesRepAccounts : IAccount
    {
        public Employees Create(IModel applicant)
        {
            Employees employee = new Employees();

            employee.FirstName = applicant.FirstName;
            employee.LastName = applicant.LastName;
            employee.EmailAddress = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@Sales.com";
            employee.IsSalesRep = true;

            return employee;
        }
    }
}
