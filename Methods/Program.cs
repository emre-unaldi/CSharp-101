using System;

namespace Methods
{
    class Program
    {
        public static void Main(string[] args) 
        {
            int a = 2;
            int b = 3;

            Methods instanceMethods = new Methods();

            int result2 = instanceMethods.IncreaseAndAdd(a, b);
            Console.WriteLine("Değişken değeri ile toplam : " + result2); // 7
            Console.WriteLine("Toplam : " + (a + b)); // 5

            Console.WriteLine("----------------------------------------");

            int result3 = instanceMethods.IncreaseAndAddRef(ref a, ref b);
            Console.WriteLine("Değişken referansı ile toplam : " + result3); // 7
            Console.WriteLine("Toplam : " + (a + b)); // 7

            Console.WriteLine("----------------------------------------");

            instanceMethods.Addition(4, 5, out int result);
            Console.WriteLine("Toplam out sonucu : " + result);

            instanceMethods.WriteScreen(10);
            Console.WriteLine(instanceMethods.WriteScreen(10, 20));
            Console.WriteLine(instanceMethods.WriteScreen(10.3d, 21.5d, 7.4d));

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Sonuç : " + instanceMethods.Expo(3,4));

            Console.WriteLine("----------------------------------------");

            string FullName = "Emre Ünaldı BM";
            bool Result = FullName.CheckSpaces();
            Console.WriteLine(Result);

            if (Result)
            {
                Console.WriteLine(FullName.RemoveWhiteSpaces());
            }

            int[] Numbers = { 98, 23, 45, 67, 89 };
            Numbers.SortArr();
            Numbers.PrintArr();
        }
    }   

    class Methods
    {
        public int IncreaseAndAddRef(ref int value1, ref int value2)
        {
            value1 += 1;
            value2 += 1;

            return value1 + value2;
        }

        public int IncreaseAndAdd(int value1, int value2)
        {
            value1 += 1;
            value2 += 1;

            return value1 + value2;
        }

        // Out parameter
        public void Addition(int value1, int value2, out int total) {
            total = value1 + value2;
        }

        // Method Overloading
        public void WriteScreen(int a)
        {
            Console.WriteLine(a);
        }
        public int WriteScreen(int a, int b)
        {
            return a + b;
        }

        public double WriteScreen(double a, double b, double c)
        {
            return (a + b) / c;
        }

        // Recursive
        public int Expo(int number, int baseNumber)
        {
            if (baseNumber < 2) return number;
            return Expo(number, baseNumber -1) * number;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }

        public static int[] SortArr(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintArr(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
    }
}