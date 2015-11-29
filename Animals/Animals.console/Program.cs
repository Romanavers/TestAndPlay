using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Archie");
            Cat cat = new Cat("Tom");
            dog.Eat();
            Shit dogShit = dog.Poop();
            dogShit.Clean();
            cat.Eat();
            Shit catShit = cat.Poop();
            catShit.Clean();
            Console.ReadLine();
            
        }
    }
}
