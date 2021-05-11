using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisir h pour homme ou f pour femme : ");
            string genre = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            switch (genre)
            {
                case("h"):
                    if (age >= 18)
                    {
                        Console.WriteLine("homme");
                    }
                    else
                    {
                        Console.WriteLine("garçon");
                    }
                    break;
                case("f"):
                    if (age >= 18)
                    {
                        Console.WriteLine("femme");
                    }
                    else
                    {
                        Console.WriteLine("fille");
                    }
                    break;
            }
        }
    }
}
