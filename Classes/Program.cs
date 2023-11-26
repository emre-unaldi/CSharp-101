using System;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker("Emre", "Ünaldı", 23, "Software");

            worker1.Name = "Ahmet";
            worker1.Surname = "Yangel";
            worker1.No = 22;
            worker1.Department= "Machine";

            worker1.WorkerInfo();
            worker2.WorkerInfo();

            Console.WriteLine("*********************************");

            Employee employee1 = new Employee("Emre", "Ünaldı", 23, "IT", 1);
            employee1.EmployeeInfo();

            employee1.IncrementDegree(); // 2
            employee1.DecrementDegree(); // 1
            employee1.DecrementDegree(); // 0 - error
            employee1.DecrementDegree(); // 0 - error

            Console.WriteLine("*********************************");

            Console.WriteLine($"Yazılım çalışanı sayısı : {SoftwareWorker.WorkerCount}");

            SoftwareWorker softwareWorker = new SoftwareWorker("Emre", "Ünaldı", "Backend");
            Console.WriteLine($"Yazılım çalışanı sayısı : {SoftwareWorker.WorkerCount}");

            Console.WriteLine(Operations.Addition(23, 45));
        }
    }

    class Worker
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;



        public Worker(){}

        public Worker(string name, string surname, int no, string department)
        {
            Name = name;
            Surname = surname;
            No = no;
            Department = department;
        }

        public void WorkerInfo()
        {
            Console.WriteLine("Çalışan adı : {0}", Name);
            Console.WriteLine("Çalışan soyadı : {0}", Surname);
            Console.WriteLine("Çalışan numarası : {0}", No);
            Console.WriteLine("Çalışan departmanı : {0}", Department);
            Console.WriteLine("------------------------------------");
        }
    }

    class Employee
    {
        private string name;
        private string surname;
        private int no;
        private string department;
        private int degree;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public string Department { get => department; set => department = value; }
        public int Degree { 
            get => degree; 
            set {
                if(value < 1)
                {
                    Console.WriteLine("Derece en az 0 olabilir!!!");
                    degree = 1;
                } else
                {
                    degree = value;
                }
            }
        }

        public Employee(string name, string surname, int no, string department, int degree)
        {
            Name = name;
            Surname = surname;
            No = no;
            Department = department;
            Degree = degree;
        }

        public Employee(){}

        public void EmployeeInfo() {
            Console.WriteLine($"İşçi adı : {this.Name}");
            Console.WriteLine($"İşçi soyadı : {this.Surname}");
            Console.WriteLine($"İşçi numarası : {this.No}");
            Console.WriteLine($"İşçi departmanı : {this.Department}");
            Console.WriteLine($"İşçi uzamnlık derecesi : {this.Degree}");
            Console.WriteLine("------------------------------------");
        }

        public void IncrementDegree()
        {
            this.Degree = this.Degree + 1;
        }

        public void DecrementDegree()
        {
            this.Degree = this.Degree - 1;
        }
    }

    class SoftwareWorker
    {
        private static int workerCount;
        private string name;
        private string surname;
        private string department;

        public static int WorkerCount { get => workerCount; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Department { get => department; set => department = value; }

        static SoftwareWorker()
        {
            workerCount = 0;
        }

        public SoftwareWorker(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
            workerCount++;
        }
    }

    static class Operations
    {
        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}