using System;
namespace uppgift5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string taltext = Console.ReadLine();
            int talet = int.Parse(taltext);
            int[] tal = { 1, 2, talet };
            Console.WriteLine(tal[0] + " "  + tal[1] + " " + tal[2]);
        }
    }
}