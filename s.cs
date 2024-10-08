using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace practicalsA
{
    internal class StringDemo
    {
        private static void Main()
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            
            int length = str.Length;
            Console.WriteLine("1. Length of the string: " + length);
            
            string upperCaseStr = str.ToUpper();
            Console.WriteLine("2. Uppercase string: " + upperCaseStr);
            
            string lowerCaseStr = str.ToLower();
            Console.WriteLine("3. Lowercase string: " + lowerCaseStr);
            
            bool containsHello = str.Contains("this");
            Console.WriteLine("4. Contains \"this\": " + containsHello);
            
            bool startsWithHello = str.StartsWith("Hello");
            Console.WriteLine("5. Starts with \"Hello\": " + startsWithHello);
            
            bool endsWithWorld = str.EndsWith("World!");
            Console.WriteLine("6. Ends with \"World!\": " + endsWithWorld);
            
            string replacedStr = str.Replace("World", "All");
            Console.WriteLine("7. Replaced string:(replaced world with all) " + replacedStr);
            
            string substring = str.Substring(7, 5);
            Console.WriteLine("8. Substring: " + substring); // Output: Substring: World!
            
            Console.WriteLine("Enter the string whose index you want to check: ");
            string str2 = Console.ReadLine();
            int indexOfWorld = str.IndexOf(str2);
            Console.WriteLine("11. Index of \"World\": " + indexOfWorld);
            
            Console.WriteLine("enter the string to be separated: ");
            string str3 = Console.ReadLine();
            string[] words = str3.Split(',');
            Console.WriteLine("10. splitting a string based on the ',' into individual element");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
