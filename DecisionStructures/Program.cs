using System;

namespace DecisionStructures
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // if-else
            int GetHour = DateTime.Now.Hour;

            if (!(GetHour > 12))
            {
                Console.WriteLine("Öğleden önce : " + GetHour);
            } else
            {
                Console.WriteLine("Öğleden sonra : " + GetHour);
            }

            // Ternary Operator
            string TimeResult = !(GetHour > 12) ? "Öğleden önce" : "Öğleden sonra";
            Console.WriteLine(TimeResult);

            // switch-case
            int GetMonth = DateTime.Now.Month;

            switch (GetMonth) 
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                default:
                    Console.WriteLine("Geçersiz değer");
                    break;
            }

            switch (GetMonth) 
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
            }
        }
    }
}