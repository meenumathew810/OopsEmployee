using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    class PayRollApp
    { 
        public void GenratePayRoll(List<Employee> employee)
        {    
            foreach (Employee e in employee)
            {
                
                Console.WriteLine("Name : "+e.Name);
                Console.WriteLine("Salary : " + e.FindSalary());
            }
            Console.ReadLine();
        }


    }
}
