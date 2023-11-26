using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Adınızı Gririn : ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Soyadınızı Girin : ");
            string surname = Console.ReadLine() ?? "";

            Console.WriteLine(name + " " + surname);
        }
    }
}