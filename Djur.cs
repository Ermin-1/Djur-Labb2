using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
                this.owner = owner;
     
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

        public class Bulldog : Djur
        {
            public string tailcolor;
            public Bulldog(string tailcolor, string eyecolor, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.tailcolor = tailcolor;
            }

            public void MakeSound()
            {
                Console.WriteLine("VOFFFFFFF VOFFFFF!");
            }

            public void Tail()
            {
                Console.WriteLine($"The {breed}s tail is color: {tailcolor}");
            }
        }

        public class Chiwauwa : Djur
        {
            public string necklaceID;
            public Chiwauwa(string necklaceID, string eyecolor, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.necklaceID = necklaceID;
            }

            public void MakeSound()
            {
                Console.WriteLine("WOFFFF WOFFF!");
            }

            public void Necklace()
            {
                Console.WriteLine($"The {age} years old {breed} was found on a countryroad with a necklasetag: {necklaceID} ");
            }
        }
        public class Cat : Djur
        {
            public string eyecolor;
            public Cat(string eyecolor, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.eyecolor = eyecolor;

            }

                public void MakeSound()
                {
                    Console.WriteLine("MJAU MJAU!");
                }
                public void Hiding()
            {
                Console.WriteLine($"The {eyecolor}eyed {breed} called {name} is hiding!");
            }
        }

        public class Horse : Djur
        {
            public string country;
            public Horse(string country, string color, string name, string breed, int age, int height) : base(color, name, breed, age, height)
            {
                this.country = country;

            }

            public void MakeSound()
            {
                Console.WriteLine("NEIGH NEIGH!");
            }

            public void Staggering()
            {
                Console.WriteLine($"With its {height}cm, the tall horse called {name} staggerd!");
            }
        }

    }

}


