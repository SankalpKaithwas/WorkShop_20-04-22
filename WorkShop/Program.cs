using System;
namespace WorkShop
{
    /*Factors
a. Desc ­> Computes the prime factorization of N using brute force.
b. I/P ­> Number to find the prime factors
c. Logic ­> Traverse till i*i <= N instead of i <= N for efficiency.
d. O/P ­> Print the prime factors of number N.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i * i <= number; i++) 
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPrime(int number)
        {
            int count = 0; 
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0) // 3 
                {
                    count++;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
