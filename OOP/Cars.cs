using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Cars
    {
        public int RubberCount()
        {
            return 4;
        }

        public virtual string StandardColor()
        {
            return "Blue";
        }

        public abstract string Brand();
    }
}
