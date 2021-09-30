using Open_Closed_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class HRModel : IModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProccessor { get; set; } = new HRAccount();
    }
}
