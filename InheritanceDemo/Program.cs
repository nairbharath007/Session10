using InheritanceDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Toddler());


        }
        static void AtThePark(Man ob)
        {
            ob.Play();
            Console.WriteLine(" at the Park!");
            Console.WriteLine("----------------------------------");
        }
    }
}
