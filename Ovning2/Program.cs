using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett tal med flera decimaler: ");
            double num = float.Parse(Console.ReadLine());
            int num1 = Convert.ToInt32(num);
            Console.WriteLine("Omvandlar {0} till närmsta heltal: {1} ", num, num1);
        }
    }
}
