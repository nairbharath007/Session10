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

            Man man = new Man(50); //para ctor of man
            Boy boy = new Boy(10); //def ctor of man --> para ctor of boy
            //if no def ctor of man, then comp error
            //as there is para ctor present in parent class(man)


        }
        static void AtThePark(Man ob)//polymorphic methods-->accepting parent as well as child methods
        {
            ob.Play();
            Console.WriteLine(" at the Park!");
            Console.WriteLine("----------------------------------");
        }
    }
}
