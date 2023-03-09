using System;
using System.Collections;

namespace TechnicalTest
{
    class Toy : IComparable
    {

        public Toy()
        {

        }

        public Toy(int Fun, int Bateries)
        {
            this.Fun = Fun;
            this.Batteries = Bateries;
        }

        public int Fun { get; set; }
        public int Batteries { get; set; }

        public override string ToString()
        {
            return this.Fun + " - " + this.Batteries;
        }

        public int CompareTo(Toy toy)
        {
            if (FunByBatery(this) < FunByBatery(toy))
            {
                return 1;
            }
            else if (FunByBatery(this) > FunByBatery(toy))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private double FunByBatery(Toy toy)
        {
            return toy.Fun / toy.Batteries;
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Toy otherToy)
                return this.CompareTo(otherToy);
            else
                throw new ArgumentException("Object is not a Toy");
        }
    }
}
