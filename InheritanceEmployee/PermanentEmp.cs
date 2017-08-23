using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEmployee
{
    class PermanentEmp: Employee
    {
        private int _PFAccountNumber, _NoOfLeaves, _Pay;
        public PermanentEmp(string name,int PFAccountNumber, int NoOfLeaves, int Pay)
        {
             Name = name;
            _PFAccountNumber = PFAccountNumber;
            _NoOfLeaves = NoOfLeaves;
            _Pay = Pay;

        }
        public override int FindSalary()
        {
            int Salary=0;
            Salary = _Pay * (30 - _NoOfLeaves) / 30;
            return Salary;
        }
    }
}
