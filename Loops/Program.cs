using System;

namespace Loops
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Döngü iterasyon sayısını girin : ");
            int LoopLength = int.Parse(Console.ReadLine());

            for (int i = 0; i < LoopLength; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------");


            int OddTotal = 0;
            int EvenTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    OddTotal += i;
                }
                else
                {
                    EvenTotal += i; 
                }
            }

            Console.WriteLine("Tek toplam : " +  OddTotal);
            Console.WriteLine("Çift toplam : " + EvenTotal);

            Console.WriteLine("------------------------");

            // Break, Contiune
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------");

            Console.Write("Sayı gir : ");
            int GetNumber = int.Parse(Console.ReadLine());
            int TotalNumbers = 0;
            int TempNumber = GetNumber;

            while (TempNumber >= 0)
            {
                TotalNumbers += TempNumber;
                TempNumber--;
            }

            int AverageNumbers = TotalNumbers / GetNumber;
            Console.WriteLine("Sayıların Toplamı : " + TotalNumbers);
            Console.WriteLine("Sayıların Ortalaması : " + AverageNumbers);

            Console.WriteLine("------------------------");
            
            // a-z tüm harfleri yazma
            char InputCharacter = 'a';
            while (InputCharacter <= 'z')
            {
                Console.Write(InputCharacter);
                InputCharacter++;
            }
            
            Console.WriteLine("\n------------------------");

            string[] cars = { "Audi", "BMV", "Ford", "Wolkswagen", "Mercedes-Benz" };

            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }

        }
    }
}