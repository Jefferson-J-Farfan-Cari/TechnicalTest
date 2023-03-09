using System;

namespace TechnicalTest
{
    class ChristmasBatteries
    {

        /**
         * B: Number of batteries
         * N: Number of toys -> 0 to (N-1)
         * X, Y, Z: Amount of fun 
         * M: Module
         * */
        public int MostFun(int B, int N, int X, int Y, int Z, int M)
        {
            Constraints(B, N, X, Y, Z, M);

            Toy[] toys = new Toy[N];
            int nb = 0;
            int totalfun = 0;

            for (int i = 0; i < N; i++)
            {
                int batteries = i % 5;
                int fun = ((((X * i) % M) * i) + (Y * i) + Z) % M; // Fun level
                if (batteries == 0)
                {
                    nb += 1;
                    totalfun += fun;
                }
                else
                {
                    toys[i] = new Toy(fun, batteries);
                }

            }
            return TotalFun(toys, nb, B) + totalfun;
        }

        public int TotalFun(Toy[] Toys, int nb, int B)
        {
            Toy[] NewToy = new Toy[Toys.Length - nb];
            int j = 0;
            int suma = 0;

            for (int i = 0; i < Toys.Length; i++)
            {
                if (Toys[i] != null)
                {
                    NewToy[j] = Toys[i];
                    j++;
                }
            }

            Array.Sort(NewToy);

            foreach (Toy t in NewToy)
            {
                if (B <= 0)
                {
                    break;
                }
                else
                {
                    if (B >= t.Batteries)
                    {
                        suma += t.Fun;
                        B -= t.Batteries;
                    }
                }
            }

            return suma;
        }

        /**
         * -	B will be between 0 and 7, inclusive.
         * -	N will be between 1 and 10^6, inclusive.
         * -	X, Y, Z will be between 0 and 999, inclusive.
         * -	M will be between 1 and 1000, inclusive.
         */
        public void Constraints(int B, int N, int X, int Y, int Z, int M)
        {
            if (B < 0 || B > 7)
            {
                throw new LimitException("B must be between 0 and 7");
            }
            if (N < 1 || N > Math.Pow(10, 6))
            {
                throw new LimitException("N must be between 1 and 10^6");
            }
            if ((X < 0 || X > 999) && (Y < 0 || Y > 999) && (Z < 0 || Z > 999))
            {
                throw new LimitException("X, Y, Z must be between 1 and 999");
            }
            if (M < 1 || M > 1000)
            {
                throw new LimitException("M must be between 1 and 1000");
            }
        }
    }
}
