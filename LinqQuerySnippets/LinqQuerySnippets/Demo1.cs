using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySnippets
{
    class Demo1
    {
        static void Main(string[] args)
        {
            //BASIC LINQ OPERATIONS

            //Sample 1 - To find the distinct factors of 48
            int[] factorsOf48 = { 1, 2, 2, 3, 4, 4, 6, 8, 8, 8, 12, 12, 12, 12, 16, 16, 24, 48 };
            int uniqueFactors = factorsOf48.Distinct().Count();
            Console.WriteLine("There are {0} unique factors of 48.", uniqueFactors);

            //Sample 2 - To find the number of even integers in the array.
            int[] numbers = { 34, 32, 90, 89, 78, 48, 39, 22, 13, 45, 67, 89 };
            int evenDigits = numbers.Count(n => n % 2 == 0);
            Console.WriteLine("There are {0} even digits in the given array ", evenDigits);

            //Sample 3 - To calculate the sum of elements in an array.
            int[] numbers = { 1, 2, 2, 3, 4, 4, 6, 8, 8, 8, 12, 12, 12, 12, 16, 16, 24, 48 };
            int sumOfDigits = numbers.Sum();
            int distinctSumOfDigits = numbers.Distinct().Sum();
            Console.WriteLine("The sum of the array is {0}", sumOfDigits);
            Console.WriteLine("The sum of distinct elements in the array is {0}", distinctSumOfDigits);

            //Sample 4 - To calculate sum of the number of characters of a string array.
            string[] s = { "a", "bb", "ccc", "dddd", "eeeee" };
            int sumOfCharacters = s.Sum(w => w.Length);
            Console.WriteLine("There are {0} characters in the array.", sumOfCharacters);

            //Sample 5 - To find the minimum and maximum elements in an array.
            int[] numbers = { 34, 32, 90, 89, 78, 48, 39, 22, 13, 45, 67, 89 };
            int lowestNumber = numbers.Min();
            int highestNumber = numbers.Max();
            Console.WriteLine("The lowest number in the array is {0} and the highest number in the array is {1}", lowestNumber, highestNumber);


        }
    }
}
