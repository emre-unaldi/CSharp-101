using System;

namespace ReadyMethods
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("------------------------- String Methods -------------------------------");

            string MySentence = "Dersimiz CSharp, Hoşgeldiniz!";
            string MySentence2 = "CSharp";

            // Length 
            Console.WriteLine($"String uzunluğu : {MySentence}");

            // ToUpper, ToLower
            Console.WriteLine($"Büyük harf : {MySentence.ToUpper()}");
            Console.WriteLine($"Büyük harf : {MySentence.ToLower()}");

            // Concat
            Console.WriteLine($"String birleştirme : {String.Concat(MySentence, " Merhaba!")}");

            // Compare, CompareTo
            Console.WriteLine($"Karşılaştırma : {MySentence.CompareTo(MySentence2)}");
            Console.WriteLine($"Karşılaştırma harf duyarlı : {String.Compare(MySentence, MySentence2, true)}");
            Console.WriteLine($"Karşılaştırma harf duyarsız : {String.Compare(MySentence, MySentence2, false)}");

            // Contains
            Console.WriteLine($"İçinde var mı ? {MySentence.Contains(MySentence2)}");
            Console.WriteLine($"Sonu verilen gibi bitiyor mu ? {MySentence.EndsWith("Hoşgeldiniz!")}");
            Console.WriteLine($"Başı verilen şekilde başlıyor mu ? {MySentence.StartsWith("Dersimiz")}");

            // IndexOf - LastIndexOf
            Console.WriteLine($"Baştan kaçıncı index : {MySentence.IndexOf("CSharp")}");
            Console.WriteLine($"Sondan kaçıncı index : {MySentence.LastIndexOf("CSharp")}");

            // Insert
            Console.WriteLine($"Stringe ekle : {MySentence.Insert(0, " Eklendi ")}");

            // PadLeft, PadRight
            Console.WriteLine(MySentence + MySentence2.PadLeft(30));
            Console.WriteLine(MySentence + MySentence2.PadLeft(30, '*'));
            Console.WriteLine(MySentence.PadRight(30) + MySentence2);
            Console.WriteLine(MySentence.PadRight(30, '*') + MySentence2);

            // Remove
            Console.WriteLine($"10. indexTen itibaren sil : {MySentence.Remove(10)}");
            Console.WriteLine($"5. index'ten başla 3 karakter sil : {MySentence.Remove(5,3)}");

            // Replace
            Console.WriteLine($"Değiştir : {MySentence.Replace("CSharp", "C#")}");

            // Split
            Console.WriteLine($"Parçala : {MySentence.Split(' ')[1]}");

            // SubString
            Console.WriteLine($"Alt diziye parçala : {MySentence.Substring(4)}");
            Console.WriteLine($"Alt diziye parçala : {MySentence.Substring(4, 8)}");

            Console.WriteLine("------------------------- DateTime Methods -------------------------------");

            Console.WriteLine($"Şuanki zaman  : {DateTime.Now}");
            Console.WriteLine($"Şuanki tarih  : {DateTime.Now.Date}");
            Console.WriteLine($"Şuanki gün    : {DateTime.Now.Day}");
            Console.WriteLine($"Şuanki ay     : {DateTime.Now.Month}");
            Console.WriteLine($"Şuanki yıl    : {DateTime.Now.Year}");
            Console.WriteLine($"Şuanki saaat  : {DateTime.Now.Hour}");
            Console.WriteLine($"Şuanki dakika : {DateTime.Now.Minute}");
            Console.WriteLine($"Şuanki saniye : {DateTime.Now.Second}");

            Console.WriteLine($"Şuanki haftanın günü  : {DateTime.Now.DayOfWeek}");
            Console.WriteLine($"Şuanki yılın günü     : {DateTime.Now.DayOfYear}");

            Console.WriteLine($"Format : {DateTime.Now.ToLongDateString()}"); 
            Console.WriteLine($"Format : {DateTime.Now.ToShortDateString()}"); 
            Console.WriteLine($"Format : {DateTime.Now.ToLongTimeString()}"); 
            Console.WriteLine($"Format : {DateTime.Now.ToShortTimeString()}");

            Console.WriteLine($"Mili Saniye ekle : {DateTime.Now.AddMicroseconds(50)}");
            Console.WriteLine($"Saniye ekle      : {DateTime.Now.AddSeconds(50)}");
            Console.WriteLine($"Dakika ekle      : {DateTime.Now.AddMinutes(2)}");
            Console.WriteLine($"Saat ekle        : {DateTime.Now.AddHours(2)}");
            Console.WriteLine($"Gün ekle         : {DateTime.Now.AddDays(5)}");
            Console.WriteLine($"Ay ekle          : {DateTime.Now.AddMonths(2)}");
            Console.WriteLine($"Yıl ekle         : {DateTime.Now.AddYears(3)}");

            // Format
            Console.WriteLine($"Format dd   : {DateTime.Now.ToString("dd")}");   
            Console.WriteLine($"Format ddd  : {DateTime.Now.ToString("ddd")}");   
            Console.WriteLine($"Format dddd : {DateTime.Now.ToString("dddd")}");   

            Console.WriteLine($"Format MM   : {DateTime.Now.ToString("MM")}");   
            Console.WriteLine($"Format MMM  : {DateTime.Now.ToString("MMM")}");   
            Console.WriteLine($"Format MMMM : {DateTime.Now.ToString("MMM")}");   

            Console.WriteLine($"Format yy   : {DateTime.Now.ToString("yy")}");   
            Console.WriteLine($"Format yyyy : {DateTime.Now.ToString("yyyy")}");  

            Console.WriteLine($"Format dd.MM.yyyy : {DateTime.Now.ToString("dd.MM.yyyy")}");
            
            Console.WriteLine("---------------------- Math Methods -------------------------");

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.3));   
            Console.WriteLine(Math.Floor(22.7));   

            Console.WriteLine(Math.Min(2, 5));
            Console.WriteLine(Math.Max(2, 5));

            Console.WriteLine(Math.Pow(2, 5)); 
            Console.WriteLine(Math.Sqrt(9)); 
            Console.WriteLine(Math.Log(9));  
            Console.WriteLine(Math.Exp(3)); 
            Console.WriteLine(Math.Log10(10)); 
        }
    }
}