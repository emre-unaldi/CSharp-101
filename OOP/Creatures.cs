using System;

namespace OOP
{
    public class Creatures
    {
        protected void Aliment()
        {
            Console.WriteLine("Tüm canlılar beslenir");
        }

        protected void Respiration()
        {
            Console.WriteLine("Tüm canlılar solunum yapar");
        }

        protected void Excretion()
        {
            Console.WriteLine("Tüm canlılar boşaltım yapar");
        }

        public virtual void Reaction()
        {
            Console.WriteLine("Canlılar uyarılara tepki verir");
        }
    }
}
