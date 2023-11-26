using System;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte unsignedByte = 200;     
            sbyte signedByte = -50;

            short signedShort = -1000;
            ushort unsignedShort = 2000;

            int signedInt = -1000000;    
            uint unsignedInt = 1000000;

            Int16 i16 = 10000;  
            Int32 i32 = 1000000; 
            Int64 i64 = 100000000;

            long signedLong = -9000000000000000000;
            ulong unsignedLong = 18000000000000000000;

            float myFloat = 3.14f;
            double myDoublee = 3.141592653589793;
            decimal myDecimal = 3.1415926535897932384626433832m;

            char myChar = 'A';
            string myString = "Hello World";

            bool isTrue = true;
            bool isFalse = false;

            object myObject1 = "Hello World";
            object myObject2 = 'c';
            object myObject3 = 4;
            object myObject4 = 2.5;

            string myConvertString = (string)myObject1;
            Console.WriteLine(myConvertString);

            string name = "Emre";
            string surname = "Ünaldı";
            string fullName = name + " " + surname;
            Console.WriteLine(fullName);

            int numberOne = 5;
            int numberTwo = 3;
            int result = numberOne * numberTwo;
            Console.WriteLine("Sonuç : " + result);

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Şuanki zaman : " + currentDate); 

            DateTime specificDate = new DateTime(2023, 12, 22, 14, 30, 0);
            Console.WriteLine("Tarihi verilen zaman : " + specificDate);

            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;
            int hour = currentDate.Hour;
            int minute = currentDate.Minute;
            int second = currentDate.Second;
            Console.WriteLine($"Yıl: {year}, Ay: {month}, Gün: {day}, Saat: {hour}, Dakika: {minute}, Saniye: {second}");

            TimeSpan difference = specificDate - currentDate; 
            Console.WriteLine($"İki tarih arasındaki fark : {difference.Days}");

            string dateTimeFormat1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Tarih zaman formatı : " + dateTimeFormat1);

            string dateTimeFormat2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Tarih zaman formatı : " + dateTimeFormat2);

            string hourFormat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Şuanki saat : " + hourFormat);

            string numberString20 = "20";
            int stringNumber20 = 20;

            string concatResult = numberString20 + stringNumber20.ToString();
            Console.WriteLine("String int birleştirme : " + concatResult);
        }
    }
}