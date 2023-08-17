using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Toddler:Man
    {
        public Toddler()
        {
            Console.WriteLine("Default Constructor of Toddler");
        }
        /*public Boy(int age)
        {
            Console.WriteLine("Parameterized Constructor of Boy");
        }*/
        public override void Play()
        {
            Console.Write(" Toddler Plays");
        }

        public void Sleep()
        {
            Console.WriteLine(" Toddler Plays");
        }
       
    }
}
