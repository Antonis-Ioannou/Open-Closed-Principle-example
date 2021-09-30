using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class ManagerAccount : IAccount
    {
        public Employees Create(IModel applicant)
        {
            Employees employee = new Employees();

            employee.FirstName = applicant.FirstName;
            employee.LastName = applicant.LastName;
            employee.EmailAddress = $"{applicant.FirstName}-{applicant.LastName}@Corporate.com";
            employee.IsManager = true;

            return employee;
        }
    }
}
