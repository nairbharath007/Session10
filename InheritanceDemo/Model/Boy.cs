using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Boy:Man
    {
        public void Play()
        {
            Console.WriteLine(" Boy Plays");
        }
        public void Eat()
        {
            Console.WriteLine(" Boy Eats");
        }
    }
}
