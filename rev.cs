using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalsA
{
    internal class sumReverse
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int num = n, reverse = 0, sum = 0, rem = 0; 
            while(num>0)
            {
                rem = num % 10;
                sum =sum+rem;
                reverse = reverse * 10 + (rem);
                num = num / 10;

            }
            Console.WriteLine("the reverse of the given number is "+reverse);
            Console.WriteLine("the sum of the given number is " + sum);
        }
    }
}
