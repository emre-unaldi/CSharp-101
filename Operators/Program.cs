using System;

namespace Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Atama ve İşlemli Atama Operatörleri *****");
            int x = 3;
            int y = 4;
            y += 2;
            
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x += 2;
            Console.WriteLine(x);


            Console.WriteLine("***** Mantıksal Operatörler *****");
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) { Console.WriteLine("Perfect");} 
            if (isSuccess ||  isCompleted) { Console.WriteLine("Great");}
            if (isSuccess &&  !isCompleted) { Console.WriteLine("Fine");}

            Console.WriteLine("***** İlişkisel Operatörler *****");
            int a = 3;
            int b = 4;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            Console.WriteLine("***** Aritmetik Operatörler *****");
            int number1 = 10;
            int number2 = 5;
            
            int result1 = number1 / number2;
            Console.WriteLine(result1);
            result1 = number1 * number2;
            Console.WriteLine(result1);
            result1 = number1 + number2;
            Console.WriteLine(result1);
            result1 = number1 - number2;
            Console.WriteLine(result1);
            result1 = number1++;
            Console.WriteLine(result1);

            int result2 = 20 % 3;
            Console.WriteLine(result2);
        }
    }
}