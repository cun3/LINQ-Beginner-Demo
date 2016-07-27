using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySnippets
{
    class Demo4
    {
        static void Main(string[] args)
        {
            //OfType Example
            object[] array = new object[4];
            array[0] = new StringBuilder();
            array[1] = "example";
            array[2] = new int[1];
            array[3] = "another";

            // Print only the strings to the screen.
            var result = array.OfType<string>();
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }
    }
}
