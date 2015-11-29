using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IAnimal
    {
        void Eat();
        Shit Poop();
        void Enjoy();
        string GetName();
    }

    public class Shit
    {
        public void Clean()
        {
            Console.WriteLine("Clean");
        }

    }

    public class Dog : IAnimal
    {
        private string Name;
        public Dog(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            string eatString = string.Format("{0} ate", GetName());
            Console.WriteLine(eatString);
        }

        public void Enjoy()
        {
            Console.WriteLine("{0} enjoyed", GetName());
        }

        public Shit Poop()
        {
            Shit shit = new Shit();
            Console.WriteLine("Pooped");
            return shit;
        }

        public string GetName()
        {
            return Name;
        }
    }

    public class Cat : IAnimal
    {
        private string Name;
        public Cat(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            string eatString = string.Format("{0} ate", GetName());
            Console.WriteLine(eatString);
        }

        public void Enjoy()
        {
            Console.WriteLine("{0} enjoyed", GetName());
        }

        public Shit Poop()
        {
            FindPlace();
            Shit shit = new Shit();
            Console.WriteLine("Pooped");
            return shit;
        }

        public string GetName()
        {
            return Name;
        }

        private void FindPlace()
        {
            Console.WriteLine("Found place");
        }
    }



}


