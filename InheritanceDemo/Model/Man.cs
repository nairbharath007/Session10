using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Man
    {
        public virtual void Play()
        {
            Console.WriteLine(" Man Plays");
        }
        public void Work()
        {
            Console.WriteLine(" Man Works");
        }
    }
}
