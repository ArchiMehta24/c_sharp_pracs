using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProg
{
    internal class LinqArr
    {
        static void Main()
        {
            int[] arr = { 4, 5, 6, 10, 3, 2, 1, 14 };
            IEnumerable<int> n = arr.Where(p => p % 2==0).Select(p => p);
            foreach(var m in n) //enhanced for loop. var data type can store anything.
            {
                Console.WriteLine(m);
            }

            int count = arr.Count(x => x > 5);
            int avg = (int)arr.Average(x => x);
            int max = arr.Max(x => x); //finding maximum no. using function
            Console.WriteLine("avg is "+avg);
            Console.WriteLine("max is " + max);
            IEnumerable<int> maxim = (from a in arr select max).Take(1); //Ttake(1) prints maxim only once. If not written it prints it arr.length() times
            foreach(var m1 in maxim) //finding maximum no. using for loop
            {
                Console.WriteLine("maxim is "+m1);
            }

            Console.WriteLine("count of numbers >5 is "+count);
            Console.ReadKey();
        }
        
    }
}
