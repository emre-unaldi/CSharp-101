using System;

namespace Classes2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangele rectangele = new Rectangele();
            Console.WriteLine($"Alan : {rectangele.AreaCalculation()}");

            //RectangeleStruct rectangeleStruct = new RectangeleStruct(3,4);
            RectangeleStruct rectangeleStruct;
            rectangeleStruct.shortEdge = 3;
            rectangeleStruct.longEdge = 4;
            Console.WriteLine($"Alan : {rectangeleStruct.AreaCalculation()}");
            
            Console.WriteLine("*******************************************");
            Console.WriteLine(Days.MONDAY); // MONDAY
            Console.WriteLine((int)Days.SATURDAY); // 6

            int temparature = 4;

            if (temparature <= (int)WeatherStatus.NORMAL)
            {
                Console.WriteLine("Dışarısı soğuk");
            }
        }

        enum Days
        {
            MONDAY = 1,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        enum WeatherStatus
        {
            COLD = 5,
            NORMAL = 20,
            HOT = 25,
            SO_HOT = 30
        }
    }

    class Rectangele
    {
        public int shortEdge;
        public int longEdge;

        public Rectangele()
        {
            shortEdge = 3;
            longEdge = 4;
        }

        public int AreaCalculation()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangeleStruct
    {
        public int shortEdge;
        public int longEdge;

        public RectangeleStruct(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }
        public int AreaCalculation()
        {
            return this.shortEdge * this.longEdge;
        }
    }
}