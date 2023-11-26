using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("------------------***** List *****--------------------");
            List<int> numberList = new List<int>();

            numberList.Add(13);
            numberList.Add(134);
            numberList.Add(156);
            numberList.Add(61);
            numberList.Add(18);

            List<string> colorList = new List<string>();
            colorList.Add("Kırmızı");
            colorList.Add("Msvi");
            colorList.Add("Turuncu");
            colorList.Add("Yeşil");
            colorList.Add("Sarı");

            // Count
            Console.WriteLine($"Uzunluk : {numberList}");
            Console.WriteLine($"Uzunluk : {colorList}");

            Console.WriteLine("--------------------------------------");

            // Foreach
            foreach(int i in numberList) { Console.WriteLine(i); }
            foreach(string i in colorList) { Console.WriteLine(i); }

            Console.WriteLine("--------------------------------------");

            // Foreach - List.Foreach
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            Console.WriteLine("--------------------------------------");

            // Remove
            numberList.Remove(13);
            colorList.Remove("Kırmızı");

            numberList.RemoveAt(0);
            colorList.RemoveAt(0);

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            Console.WriteLine("--------------------------------------");

            // Contains
            Console.WriteLine($"18 var mı : {numberList.Contains(18)}");

            Console.WriteLine("--------------------------------------");

            // BinarySearch
            Console.WriteLine($"Sarı var mı : {colorList.BinarySearch("Sarı")}");

            Console.WriteLine("--------------------------------------");

            // Array to convert List
            string[] animals = { "Kedi", "Köpek", "Kuş" };
            List<string> animalList = new List<string>();
            animalList.ForEach(animal => Console.WriteLine(animal));

            // Clear
            animalList.Clear();

            Console.WriteLine("--------------------------------------");

            List<Users> usersList = new List<Users>();

            Users user1 = new Users("Emre", "Ünaldı", "22");
            Users user2 = new Users("Emree", "Ünaldıı", "23");

            usersList.Add(user1);
            usersList.Add(user2);
            
            usersList.ForEach(user => Console.WriteLine($"{user.Name} - {user.Surname} - {user.Age}"));

            usersList.Add(new Users("Serkan", "Ünal", "28"));

            foreach (Users user in usersList)
            {
                Console.WriteLine($"{user.Name} - {user.Surname} - {user.Age}");
            }

            Console.WriteLine("------------------***** ArrayList *****--------------------");

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(8.4);
            list.Add(true);
            list.Add("Emre");

            Console.WriteLine(list[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------");

            // AddRange
            string[] colors = { "Kırmızı", "Mavi", "Siyah" };
            List<int> numbers = new List<int>() { 1,4,6,9,4,8};

            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------");

            // Sort 
            numbers.Sort();

            // BinarySearch
            Console.WriteLine(numbers.BinarySearch(4));

            // Reverse
            numbers.Reverse();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Clear 
            numbers.Clear();

            Console.WriteLine("------------------***** Dictionary *****--------------------");

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Emre");
            users.Add(2, "Emre1");
            users.Add(3, "Emre2");
            users.Add(4, "Emre3");

            Console.WriteLine(users[1]);

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            // Count
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine("Anahtar var mı ? " + users.ContainsKey(1));
            Console.WriteLine("Değer var mı ? " + users.ContainsValue("Emre"));

            // Remove
            users.Remove(1);
            foreach (var item in users)
            {
                Console.WriteLine(item.Value);
            }

            // Keys
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }

            // Values
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Users
    {
        private string name;        
        private string surname;
        private string age;

        public Users(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Age { get => age; set => age = value; }
    }
}