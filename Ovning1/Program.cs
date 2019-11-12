using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in första talet: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Summan av tal 1 och tal 2 är: ");
            Console.WriteLine(num1 + num2);
        }
    }
}
