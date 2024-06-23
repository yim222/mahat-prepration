using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_izhar_mashkif2.euler_problems
{
    public class MathServices
    {


        public static bool IsPrime(long num)
        {


            if(num < 2) { return false; }
            else if(num == 2 || num ==3 ) { return true; }
            else if( num % 2 == 0 ) { return false; }

            //getting upper bound 

            long upper = (long)Math.Sqrt(num);

            //I think that because it's odd number it's always odd, and no need to do it odd
            // -- after checking - it's not true, so let set it even
            if (upper % 2 == 0) upper--;

            //Console.WriteLine("Upper = " + upper);
            
            for(int i = 3; i <= upper; i+=2)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
           
            return true;
        }

    }
}
