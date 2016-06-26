using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySnippets
{
    class Demo2
    {
        static void Main(string[] args)
        {
            //Sample 1 - To arrange an integer array in ascending and descending order.
            int[] numbers = { 15, 22, 27, 78, 65, 36, 39, 20, 99, 93, 46, 78, 22, 34, 57, 19 };
            var ascending = numbers.OrderBy(x => x);
            var descending = numbers.OrderByDescending(x => x);
            Console.WriteLine("The ascending order is :");
            foreach (var number in ascending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("The descending order is :");
            foreach (var number in descending)
            {
                Console.WriteLine(number);
            }

            //Sample 2-To determine the length of each string in an array.
            string[] s = { "a", "bb", "ccc", "dddd", "eeeee" };
            int[] length = s.Select(x => x.Length).ToArray();
            Console.WriteLine("The length of each element in the array are");
            foreach (int i in length)
            {
                Console.WriteLine(i);
            }

            //Sample 3 - To return elements of a paticular data type.
            object[] objectArray = {null, 6 , "abcd", 56.09,  new StringBuilder(), 78, -65, "test", null};
            var intType = objectArray.OfType<int>();

            foreach (var item in intType)
            {
                Console.WriteLine(item);
            }
        }
    }
}
