using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceApp.Model
{
    internal class Manager:Employee
    {
        public int Incentive { get; set; }
        public Manager() { }

        public Manager(int empId, string name, int age, double salary, int incentive) 
            :base(empId,name,age,salary)
        {
            Incentive = incentive;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails()+
                $"\n Incentive :{Incentive}";
        }
    }
}
