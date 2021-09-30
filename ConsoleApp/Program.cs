using Open_Closed_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IModel> models = new List<IModel>
            {
                new ManagerModel {FirstName="David", LastName="Niven"},
                new SalesRepModel {FirstName="Peter", LastName="Sellers"},
                new SalesRepModel {FirstName="John", LastName="Cleese"},
                new HRModel {FirstName="Tilda", LastName="Swinton"},
            };

            List<Employees> employeeslist = new List<Employees>();

            foreach (var employee in models)
            {
                employeeslist.Add(employee.AccountProccessor.Create(employee));
            }

            foreach (var emp in employeeslist)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} \n| IsManager: {emp.IsManager} | IsHR: {emp.IsHR} | IsSalesRep: {emp.IsSalesRep} |\n");
            }
            Console.ReadLine();
        }
    }
}
