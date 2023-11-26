using System;

namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args) 
        {
            try
            {
                Console.Write("Bir sayı girin : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı : " + number);
            } catch(Exception ex) 
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            } finally
            {
                Console.WriteLine("Her durumda çalışırım");
            }

            try
            {
                int MyInt = int.Parse("-2000000000000000000000000");
            } catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girildi : " + ex);
            } catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil : " + ex);
            } catch (OverflowException ex)
            {
                Console.WriteLine("Veri tipi sınırlarıan uygun olmayan değer girildi : " + ex);
            }
        }
    }
}