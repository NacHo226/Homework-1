using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -455;
            double d = 1088.9022;
            float f = -1549.39f;
            char c = '%';
            short sh = -28;
            bool b = true;
            const decimal m = 333897987.3949M;
            long l1 = 20003909;
            var pi = 3.1415; // pi - типа double
            string s1 = "Hello ", s2 = "world!", s3 = s1 + s2;
            Console.WriteLine(s3);
        }
    }
}