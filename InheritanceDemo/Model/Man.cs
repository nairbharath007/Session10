using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Man
    {
        public Man()
        {
            Console.WriteLine("Default Constructor of Man");
        }
        public Man(int age)
        {
            Console.WriteLine("Parameterized Constructor of Man");
        }
        public virtual void Play()
        {
            Console.Write(" Man Plays");
        }
        public void Work()
        {
            Console.WriteLine(" Man Works");
        }
    }
}
