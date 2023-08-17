using CollegeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowPersonDetails(new Student(101, "Address1","13/12/1990","CS"));
            ShowPersonDetails(new Professor(201, "Address2","12/12/2005",20000000));
            ShowPersonDetails(new Student(102, "Address3","01/05/1999","PG"));
            ShowPersonDetails(new Professor(202, "Address4","11/03/1982",1500000));
        }
        static void ShowPersonDetails(Person person)
        {
            Console.WriteLine($"============ROLE: {person.GetType().Name}===============");
            Console.WriteLine(person.PrintDetails());
        }
    }
    }

