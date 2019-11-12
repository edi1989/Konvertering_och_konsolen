using System;

namespace Ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vänligen skriv ditt namn: ");
            string name = Console.ReadLine();
            Console.Write("Vänligen ange ditt födelsedatum YYYY-MM-DD: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime thisDay = DateTime.Today;
            TimeSpan days = date - thisDay;

            TimeSpan diff = thisDay - date;
            Console.WriteLine("Hej "+name+ ". Du har levt " + diff.TotalDays.ToString()+ " dagar på denna jord!");

        }
    }
}
