using System;
using DesignPatterns.Facotry;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("1. Singleton");
                Console.WriteLine("2. Factory: people have pet1");
                Console.WriteLine("3. Factory: people have pet2");
                Console.WriteLine("4. Exit");
                Console.WriteLine("--Please select the option--");

                do
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch { }
                } while (true);

                switch (choice)
                {
                    case 1:
                        Singleton.Instance.Call();
                        break;
                    case 2:
                        People firstPeo = new PeopleHaveDog();
                        firstPeo.SetPet();
                        firstPeo.PetInfo();
                        break;
                    case 3:
                        People SecondPeo = new PeopleHaveCat();
                        SecondPeo.SetPet();
                        SecondPeo.PetInfo();
                        break;
                }
            } while (choice != 4);
        }
    }
}
