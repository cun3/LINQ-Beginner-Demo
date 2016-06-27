using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySnippets
{
    class Demo3
    {
        static void Main(string[] args)
        {
            //First, First or Default and Elementat functions.

            //To find the first element starting with a particular letter
            string[] cities = { "Atlanta", "Miami", "Boston", "NewYork", "San Francisco", "Los Angeles", "Las Vegas" };
            string city = cities.First(x => x[0] == 'L');
            Console.WriteLine("The first occurence of letter L is {0}", city);

            //To find all the elements starting with a particular letter
            string[] cities = { "Atlanta", "Miami", "Boston", "NewYork", "San Francisco", "Los Angeles", "Las Vegas" };
            string[] city = cities.Select(x => x[0] == 'L');
            Console.WriteLine("The first occurence of letter L is {0}", city);


            //To manage the case when there is no matching value.
            int[] numbers = { 16, 27, 12, 15, 87, 55 };
            int val = numbers.FirstOrDefault(x => x > 100);
            Console.WriteLine("Result = {0}", val);

            //To find the second lowest number.
            int[] numbers = { 16, 27, 12, 15, 87, 55 };
            int val = numbers.OrderBy(x => x).ElementAt(1);
            Console.WriteLine("Result = {0}", val);

        }
    }
}
