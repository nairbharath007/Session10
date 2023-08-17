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

            Man man1 = new Boy();
            man1.Play();  //Play() of child and not of parent
            //man1.Eat(); //exclusive to child not known to parent

            Boy boy1 = (Boy)man1;
            boy1.Eat();
            ((Boy)man1).Eat();

        }
    }
}
