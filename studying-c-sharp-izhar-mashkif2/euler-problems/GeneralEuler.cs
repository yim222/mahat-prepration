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



           long[] numbers = {1,2, 3, 4, 5, 6, 7,8,9,10,11,12,13,15,17,19,21,23};
            Console.WriteLine("Test if is Prime is working:");
            for(int i = 0; i < numbers.Length; i++)
            {
                if (MathServices.IsPrime(numbers[i]))
                {
                    Console.Write(numbers[i] + ",");
                }
            }
        }

        public static void SolveProblem3()
        {

        }
    }
}
