using System;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder?");
            string response = Console.ReadLine().ToLower();

            if (response == "j")
            {
                Console.WriteLine("Jag tycker du ska ta vara på vädret och gå ut på en picknick.");
            }
            if (response == "n")
            {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            }

        }
    }
}
