using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_izhar_mashkif2.draft
{
    public class MyDraftArea
    {

        public void Draft1()
        {

            Console.WriteLine("Draft area");

            Console.WriteLine("List...");

            List<int> numberslist = new List<int>();

            numberslist.Add(12);

            numberslist.Add(22);

            //print list
            Console.WriteLine(String.Join(",", numberslist));


            Queue<int> ints2 = new Queue<int>();

            ints2.Enqueue(1);
            ints2.Enqueue(11);

            Console.WriteLine("ints2 = " + string.Join("|", ints2));


        }
    }
}
