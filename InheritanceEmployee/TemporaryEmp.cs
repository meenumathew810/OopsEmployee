using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    class TemporaryEmp: Employee
    {
        private int _ContractDate, _WagePerHour, _HoursWorked,_Ot;
        public TemporaryEmp(string name,int ContractDate, int WagePerHour, int HoursWorked, int Ot)
        {
             Name = name;
            _ContractDate = ContractDate;
            _WagePerHour = WagePerHour;
            _HoursWorked = HoursWorked;
            _Ot = Ot;

        }
        public override int FindSalary()
        {
            int Salary = 0;
            Salary = (_HoursWorked + _Ot * 2) * _WagePerHour;
            return Salary;
        }


    }
}
