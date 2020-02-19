using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_3
{
    public class PrimeNumbers
    {
        private int x;

        public int X { get => x; set => x = value; }

        public PrimeNumbers(int x)
        {
            this.x = x;
        }

        public static bool IsPrime(int x)
        {
            bool yesIsPrim = true;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    yesIsPrim = false;
                }
            }
            return yesIsPrim;
        }

        public static int GivePrime(int x)
        {

            int counter = 2;
            List<int> primeNums = new List<int>();

            do
            {
                if (IsPrime(counter))
                {
                    primeNums.Add(counter);
                }
                counter++;
            } while (primeNums.Count < x);

            return primeNums[x - 1];

        }
    }
}
