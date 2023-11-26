using System;

namespace OOP
{
    public class Plants : Creatures
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }

        public override void Reaction()
        {
            base.Reaction();
            Console.WriteLine("Bitkiler temasa tepki verir.");
        }
    }

    public class SeedyPlants : Plants
    {
        public SeedyPlants()
        {
            base.Photosynthesis();
            base.Aliment();
            base.Respiration();
            base.Excretion();
            base.Reaction();
        }
        public void ReproductionBySeed()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
            base.Aliment();
            base.Respiration();
            base.Excretion();
            base.Reaction();
        }
        public void ReproductionBySpores()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }
}
