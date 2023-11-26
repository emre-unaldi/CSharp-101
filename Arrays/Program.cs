using System;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string[] colors = new string[3];
            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            colors[0] = "red";
            colors[1] = "black";
            colors[2] = "blue";

            Console.WriteLine(animals[0]);
            Console.WriteLine(colors[1]);

            Console.WriteLine("---------------------------------");

            Console.Write("Dizi kaç elemanlı olacak ? ");
            int ArrayLength = int.Parse(Console.ReadLine());
            int[] numberArr = new int[ArrayLength];

            for (int i = 0; i < ArrayLength; i++)
            {
                Console.Write($"Dizinin {i}. sayı elemanını girin : ");
                numberArr[i] = int.Parse(Console.ReadLine());
            }

            int TotalArr = 0;
            foreach (int item in numberArr)
            {
                TotalArr += item;
                Console.WriteLine(item);               
            }
            Console.WriteLine($"Değerlerin Toplamı : {TotalArr}");
            Console.WriteLine($"Değerlerin Ortalamsı : {TotalArr / numberArr.Length}");

            Console.WriteLine("---------------------------------");

            // Sort
            int[] numbers = { 23, 45, 76, 7, 3, 8, 34, 90 };
            Array.Sort(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------");

            // Clear
            Array.Clear(numbers, 2, 2);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------");

            // Reverse
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------");

            // IndexOf
            int SearchIndex = Array.IndexOf(numbers, 76);
            Console.WriteLine(SearchIndex + 1);

            Console.WriteLine("---------------------------------");

            // Resize
            Array.Resize<int>(ref numbers, 9);
            numbers[8] = 99;
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}