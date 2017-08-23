using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeRepository repo = new EmployeeRepository();
            PayRollApp payroll = new PayRollApp();
            
            payroll.GenratePayRoll(repo.GetEmployee());
        }


        
    }
}
