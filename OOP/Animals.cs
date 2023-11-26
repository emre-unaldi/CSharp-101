using System;

namespace OOP
{
    public class Animals : Creatures
    {
        protected void Adaptation()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void Reaction()
        {
            base.Reaction(); // Üst sınıftaki fonksiyonu da çalıştırır.
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }

    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Aliment();
            base.Respiration();
            base.Excretion();
            base.Reaction();
        }
        public void Grovel()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Aliment();
            base.Respiration();
            base.Excretion();
            base.Reaction();
        }
        public void Fly()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
