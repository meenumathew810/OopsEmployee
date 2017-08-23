using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    class EmployeeRepository
    {
        
        public List<Employee> GetEmployee()
        {
            List<Employee> employee = new List<Employee>();

            employee.Add(new PermanentEmp("ann", 2342, 3, 2500));
            employee.Add(new TemporaryEmp("elaine", 22, 200, 9, 5));
            return employee;

        }
    }
}
