using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var detector = new FizzBuzzDetector();

            string input1 = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
            var result1 = detector.GetOverlappings(input1);
            Console.WriteLine("Test 1: " + result1.OutputString);
            Console.WriteLine("Count: " + result1.Count);
        }
    }
}
