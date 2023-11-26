using System;

namespace TypeConversions
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // Type Conversions

            Console.WriteLine("----- Explicit Conversion -----");
            // Explicit Conversion
            // byte < short < int < long < float < double < decimal

            // double -> int
            double MyDouble = 12.45;
            int MyInt = (int)MyDouble;
            Console.WriteLine("int -> double : " + MyInt);

            // int -> byte
            int MyIntX = 4;
            byte MyByteY = (byte)MyIntX;
            Console.WriteLine("int -> byte : " + MyByteY);

            // float -> byte
            float MyFloatB = 10.3f;
            byte MyByteF = (byte)MyFloatB;
            Console.WriteLine("float -> byte : " + MyByteF);
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("----- Implicit Conversion -----");
            // Implicit Conversion
            // byte < short < int < long < float < double < decimal

            // int -> double
            int MyInt2 = 42;
            double MyDouble2 = MyInt2;
            Console.WriteLine("int -> double : " + MyDouble2);

            // byte,sbyte,short -> int
            byte MyByte = 5;
            sbyte MySByte = 30;
            short MyShort = 10;
            int MyInt3 = MyByte + MySByte + MyShort;
            Console.WriteLine("byte,sbyte,short -> int : " + MyInt3);

            // int -> long
            long MyLong = MyInt3;
            Console.WriteLine("int -> long : " + MyLong);

            // long -> float
            float MyFloat = MyLong;
            Console.WriteLine("long -> float : " + MyFloat);

            // string,char -> object
            string myString = "Emre";
            char MyChar = 'e';
            object MyObject = myString + MyChar;
            Console.WriteLine("string,char -> object : " + MyObject);

            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("----- Convert Class -----");
            // Convert Class

            // string -> int
            string NumberString = "123";
            int NumberInt = Convert.ToInt32(NumberString);
            Console.WriteLine("string -> int32 : " + NumberInt);

            string NumberString20 = "20";
            int StringNumber20 = 20;

            int Int21 = StringNumber20 + Convert.ToInt32(NumberString20);
            Console.WriteLine("string -> int32 : " + Int21);

            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("----- ToString Method -----");
            // int -> string
            int MyIntS = 6;
            string MyStringI = MyIntS.ToString();
            Console.WriteLine("int -> string : " + Int21);

            // double -> string
            string MyStringD = 12.5f.ToString();
            Console.WriteLine("double -> string : " + MyStringD);

            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("----- Parse - TryParse Method -----");
            // Parse - TryParse

            // string -> int 
            string NumberString2 = "123";
            int NumberInt3 = int.Parse(NumberString2);
            Console.WriteLine("string -> int : " + NumberInt3);

            // string -> double
            string DoubleString = "20.25";
            Double StringDouble = Double.Parse(DoubleString);
            Console.WriteLine("string -> double : " + StringDouble);

            // string -> int
            int MyParseInt;
            bool ParseSuccess = int.TryParse(NumberString2, out MyParseInt);
            Console.WriteLine("Dönüşüm başarılı mı ? " + ParseSuccess + " string -> int : " + NumberInt3);

            int Int22 = StringNumber20 + int.Parse(NumberString20);
            Console.WriteLine("String int dönüştürme : " + Int22);

            Console.WriteLine("-------------------------------\n");

            // Boxing - Unboxing

            // Boxing
            // int -> object
            int MyInt4 = 42;
            object BoxedInt = MyInt4;
            Console.WriteLine("int -> object : " + BoxedInt);

            // Unboxing
            // object -> int
            int UnBoxedInt = (int)BoxedInt;
            Console.WriteLine("object -> int : " +UnBoxedInt);
        }
    }
}