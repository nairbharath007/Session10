using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceApp.Model
{
    internal class Clerk:Employee
    {
        public int Bonus { get; set; }
        public Clerk() { }

        public Clerk(int empId, string name, int age, double salary, int bonus)
            :base(empId,name,age,salary)
        {  Bonus = bonus; }

        public override string PrintDetails()
        {
            return base.PrintDetails() +
                $" \n Bonus: {Bonus}";
        }

    }
}
