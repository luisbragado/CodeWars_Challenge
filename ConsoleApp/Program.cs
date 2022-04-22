using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Kata: KataDuplicateEncode
            //string result = CodewarsKatas.KataDuplicateEncode.DuplicateEncode("Success");
            //Console.WriteLine(String.Format("Result: {0}", result));

            ////Kata: Find Odd Int
            //var result = CodewarsKatas.FindOdd.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
            //Console.WriteLine(String.Format("Result: {0}", result));            

            //Kata: Moving Zeros to the End
            var result = CodewarsKatas.MovingZerosToTheEnd.MoveZeroes(new[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            Console.WriteLine(String.Format("Result: {0}", result));
        }
    }
}
