namespace Djur
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Djur.Dog dog = new Djur.Dog("Ermin", "Blue", "Hugo", "Chiuwawa", 6, 45);
            dog.MakeSound();
            dog.Sniffing();

            Console.WriteLine("---------------------");

            Djur.Cat cat = new Djur.Cat("Black", "Black", "Evert", "Ragdoll", 20, 60);
            cat.MakeSound();
            cat.Hiding();

            Console.WriteLine("---------------------");

            Djur.Horse horse = new Djur.Horse("Middle-earth", "White", "Shadowfax", "Meras", 30, 150);
            horse.MakeSound();
            horse.Staggering();

            Console.WriteLine("---------------------");

            Djur.Bulldog bulldog = new Djur.Bulldog("brown", "grey", "black", "Lancelot", "Bulldog", 10, 47);
            bulldog.MakeSound();
            bulldog.HowOld();
            bulldog.Tail();

            Console.WriteLine("---------------------");

            Djur.Chiwauwa chiwauwa = new Djur.Chiwauwa("11875", "White", "black", "Lancelot", "Chiwauwa", 10, 47);
            chiwauwa.MakeSound();
            chiwauwa.Necklace();
            chiwauwa.Running();
            chiwauwa.Sleeping();
            

        }
    }
}