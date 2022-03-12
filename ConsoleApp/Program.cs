using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata: KataDuplicateEncode
            string result = CodewarsKatas.KataDuplicateEncode.DuplicateEncode("Success");
            Console.WriteLine(String.Format("Result: {0}", result));
        }
    }
}
