using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_izhar_mashkif2.euler_problems
{
    public class GeneralEuler
    {

        public static void TestEuler()
        {
            Console.WriteLine("Euler: ");



            long[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 17, 19, 21, 23 };
            Console.WriteLine("Test if is Prime is working:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (MathServices.IsPrime(numbers[i]))
                {
                    Console.Write(numbers[i] + ",");
                }
            }

            Console.WriteLine("\nSolve problem 3");
            long num = 600851475143;
            SolveProblem3(num);

            SolveProblem3(35);//7
            SolveProblem3(14);//7
            SolveProblem3(13);//is prime
            SolveProblem3(28);//7 ---> wrong answer

            //SolveProblem3V2(num);
            //SolveProblem3V2(35);//7
            //SolveProblem3V2(14);//7
            //SolveProblem3V2(13);//is prime
            //SolveProblem3(28);//7 ---> wrong answer


            int big = 999 * 999;
            Console.WriteLine("big = " + big / 999);

            Console.WriteLine("Test is palindrom ");

            long[] numbers2 = { 113, 9099, 9009, 12321, 456654 };

            foreach (int i in numbers2)
            {
                Console.WriteLine(i + " is palindrom ? " + MathServices.IsPalindrome(i.ToString()));
            }

            //test small example: 

            SolveProblem4(10, 99);

            SolveProblem4(1000, 9999);
        }

        public static void SolveProblem3(long num)
        {
           
            //long num = 17;
            long upper = (long)Math.Sqrt(num);
            //long upper = num / 2;
            //Console.WriteLine(upper * upper);

            if (upper % 2 == 0) upper--;
            //Console.WriteLine("upper = " + upper ) ;
            for (long i = upper; i >= 3; i -= 2)
            {
                if (num % i == 0)
                {
                    if (MathServices.IsPrime(i))
                    {

                        if (MathServices.IsPrime(num / i))
                        {
                            i = num / i;
                        }
                        Console.WriteLine("Result = {0} * {1} = {2}|  {3} is the largest prime factor" , i, num/i, num, i );
                        return;
                    }
                }
            }
            if (num % 2 == 0)
            {

                long result = MathServices.IsPrime(num / 2) ? num / 2 : 2;

                Console.WriteLine("Result = {0} * {1} = {2}|  {3} is the largest prime factor", num/2, 2, num, result);
                return;


            }
            else
            {
                Console.WriteLine("{0} number is prime", num);
            }

        }


        public static void SolveProblem3V2(long num)
        {

            //long num = 17;
            //long upper = (long)Math.Sqrt(num);
            long upper = num / 2;
            //Console.WriteLine(upper * upper);
            long lowest = (long)Math.Sqrt(num);
            long  lastPrimeFactor = 0;
            //if (upper % 2 == 0) upper--;
            //Console.WriteLine("upper = " + upper ) ;
            for (long i = upper; i >= lowest; i --)
            {
                if (num % i == 0)
                {
                    long divider = num / i;
                    if (MathServices.IsPrime(i) && MathServices.IsPrime(divider))
                    {                      
                        long temp = Math.Max(lastPrimeFactor, divider);

                        if(temp > lastPrimeFactor)
                        {
                            lastPrimeFactor = temp;
                        }
                        
                    }
                }
            }

            if(lastPrimeFactor > 0)
            {
                Console.WriteLine("Result = {0} {2} is the largest prime factor", num, lastPrimeFactor);
                return;
            }
            //if (num % 2 == 0)
            //{

            //    long result = MathServices.IsPrime(num / 2) ? num / 2 : 2;

            //    Console.WriteLine("Result = {0} * {1} = {2}|  {3} is the largest prime factor", num / 2, 2, num, result);
            //    return;


            //}
            //else
            //{
            //}
            Console.WriteLine("{0} number is prime", num);


        }


        //getting some range
        public static void SolveProblem4(int lowerBound, int upperBound)
        {

            //variable for hold the last palindrom
            int maxPalindrom = 0;
            int smallJ = 0;

            for (int i = upperBound; i >= lowerBound; i--)
            {
                //Console.WriteLine("i = " + i);//for test
                if (i <= smallJ)
                {
                    break;
                }
                //if it's divided by 10 - continue to the next loop
                if (i % 10 == 0)
                {
                    continue;
                }
                //inner loop from this number
                for (int j = i; j >= lowerBound; j--)

                {
                    if (j % 10 == 0)
                    {
                        continue;
                    }

                    int product = i * j;

                    //if it's palindrom
                    if (MathServices.IsPalindrome(product.ToString()))
                    {

                        if (product > maxPalindrom)
                        {
                            //for test
                            Console.WriteLine($"{i} * {j} = {product}");
                            maxPalindrom = product;
                            smallJ = j;
                        }
                    }
                }//end of inner loop

            }//end of outer loop
            Console.WriteLine("result = " + maxPalindrom);
        }
    }
}
