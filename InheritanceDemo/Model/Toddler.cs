using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Toddler:Man
    {
        public override void Play()
        {
            Console.WriteLine(" Toddler Plays");
        }

        public void Sleep()
        {
            Console.WriteLine(" Toddler Plays");
        }
       
    }
}
