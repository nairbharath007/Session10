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
            /*AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Toddler());*/

            Man man = new Man(50);
            Boy boy = new Boy(10);


        }
        static void AtThePark(Man ob)//polymorphic methods-->accepting parent as well as child methods
        {
            ob.Play();
            Console.WriteLine(" at the Park!");
            Console.WriteLine("----------------------------------");
        }
    }
}
