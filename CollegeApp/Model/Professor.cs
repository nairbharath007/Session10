using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Professor:Person
    {
        public double Salary { get; set; }

        public Professor() { }

        public Professor(int id, string address, string dob, double salary)
            : base(id, address, dob)
        {
            Salary = salary;
        }

        public static double SalaryCalc(double salary)
        {
            double netMonthlySalary = salary/15;
            return netMonthlySalary;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails()+
                $"\n Salary: {SalaryCalc(Salary)}";
        }
    }
}
