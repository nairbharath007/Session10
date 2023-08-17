using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Boy:Man
    {
        public Boy() 
        {
            Console.WriteLine("Default Constructor of Boy");
        }
        public Boy(int age)
        {
            Console.WriteLine("Parameterized Constructor of Boy");
        }
        public override void Play()
        {
            Console.Write(" Boy Plays");
        }
        public void Eat()
        {
            Console.WriteLine(" Boy Eats");
        }
    }
}
