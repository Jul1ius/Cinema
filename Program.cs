using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (type == "Premiere")
            {
                income = redove * koloni * 12;
            }
            else if (type == "Normal")
            {
                income = koloni * redove * 7.5;
            }
            else if (type == "Discount")
            {
                income = redove * koloni * 5;
            }
            Console.WriteLine(income);
        }
    }
}
