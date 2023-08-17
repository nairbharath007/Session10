using EmployeeInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace EmployeeInheritanceApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ShowEmployeeDetails(new Clerk(101, "Clerk1", 50, 20000, 5000));
            ShowEmployeeDetails(new Manager(201, "Manager1", 150, 2, 500000000));
        }
        static void ShowEmployeeDetails(Employee employee) 
        {
            Console.WriteLine($"============ROLE: {employee.GetType().Name}===============");
            Console.WriteLine(employee.PrintDetails());
        }
    }
}
