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
            Man man = new Man();
            man.Play();
            man.Work();
            Console.WriteLine("------------------------------------");
            Boy boy = new Boy();
            boy.Play();
            boy.Eat();
            Console.WriteLine("------------------------------------");

            Toddler toddler = new Toddler();
            toddler.Play();
            toddler.Sleep();
            Console.WriteLine("------------------------------------");

        }
    }
}
