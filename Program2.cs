using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            Console.WriteLine(i++);          // output: 3
            double a = 1.5;
            Console.WriteLine(++a);          // output: 2.5
            Console.WriteLine(i--);          // output: 4 
            Console.WriteLine(-a);           // output: -2.5
            Console.WriteLine(i * a);        // output: 7.5
            Console.WriteLine(i / a);        // output: 1.2
            Console.WriteLine(5 % 4);        // output: 1
            Console.WriteLine(5 + 4);        // output: 9
            Console.WriteLine(5 - 4);        // output: 1
            Console.WriteLine(7.0 < 5.1);    // output: False
            Console.WriteLine(7.0 <= 5.1);   // output: False
            Console.WriteLine(7.0 >= 5.1);   // output: True
            Console.WriteLine(!true);        // output: False
            Console.WriteLine(true & false); // output: False
            Console.WriteLine(true ^ true);  // output: False
            Console.WriteLine(true | true);  // output: True
            Console.WriteLine(true || true); // output: True
            Console.WriteLine(true && false);// output: False
            string s1 = "hello!";
            string s2 = "hello!";
            Console.WriteLine(s1 == s2);     // output: True
            Console.WriteLine(s1 != s2);     // output: False
        }
    }
}