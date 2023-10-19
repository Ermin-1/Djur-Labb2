using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djur
{
    internal class Djur
    {
        public string color;
        public string name;
        public string breed;
        public int age;
        public int height;

        public Djur(string color, string name, string breed, int age, int height)
        {
            this.color = color;
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.height = height;
        }

        public void Sleeping()
        {
            Console.WriteLine($"The {breed} called {name} is currently sleeping...");
        }

        public void HowOld()
        {
            Console.WriteLine($"The {breed} that is {color} is {age} years old!");
        }

        public void Running()
        {
            Console.WriteLine($"The {breed} called {name} is running very fast!");
        }

        public class Dog : Djur
        {
            public string owner;
            public Dog(string owner, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.owner = "Ermin";
                this.color = "Black";
                this.name = "Hugo";
                this.breed = "Labrador";
                this.age = 7;
                this.height = 56;

            }
            public void MakeSound()
            {
                Console.WriteLine("VOFF VOFF!");
            }
            public void Sniffing()
            {
                Console.WriteLine($"{name} is sniffing around {owner}s feet!");
            }

        }

        public class Cat : Djur
        {
            public string eyecolor;
            public Cat(string eyecolor, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.eyecolor = "Blue";
                this.color = "Black";
                this.name = "Bingo";
                this.breed = "Ragdopll";
                this.age = 4;
                this.height = 43;
            }

                public void MakeSound()
                {
                    Console.WriteLine("MJAU MJAU!");
                }
        }

        public class Horse : Djur
        {
            public string country;
            public Horse(string country, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.country = "Middle-earth";
                this.color = "White";
                this.name = "Shadowfax";
                this.breed = "Mearas";
                this.age = 15;
                this.height = 158;
            }

            public void MakeSound()
            {
                Console.WriteLine("NEIGH NEIGH!");
            }
        }
    }
}


