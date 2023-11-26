using System;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            SeedyPlants seedyPlants = new SeedyPlants();
            seedyPlants.ReproductionBySeed();

            Console.WriteLine("******************************");

            Birds bird = new Birds();
            bird.Fly();

            Console.WriteLine("******************************");

            FileLogger fileLogger = new FileLogger();
            DatabaseLogger databaseLogger = new DatabaseLogger();

            fileLogger.WriteLog();
            databaseLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

            Console.WriteLine("******************************");
            BMV bmv = new BMV();
            Console.WriteLine(bmv.RubberCount());
            Console.WriteLine(bmv.StandardColor());
            Console.WriteLine(bmv.Brand());
        }
    }
}