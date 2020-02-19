using System;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            PrimeNumbers p1 = new PrimeNumbers(num);

            int primenum = PrimeNumbers.GivePrime(num);
            Console.WriteLine(primenum);
        }
    }
}
