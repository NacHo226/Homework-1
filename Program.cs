using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void ConsoleWrite(string inputArg)
        {
            Console.WriteLine(inputArg);
        }
        static void Main(string[] args)
        {
            int i = -455;
            byte byte1 = 1;
            sbyte sbyte1 = -101;
            uint a = 10;
            uint uin1 = 0b101;
            ulong ulo = 10;
            ulong ilo2 = 0b101;
            double d = 1088.9022;
            float f = -1549.39f;
            char c = '%';
            short sh = -28;
            bool b = true;
            const decimal m = 333897987.3949M;
            long lo1 = 20003909;
            var pi = 3.1415; // pi - типа double
            string s1 = "Hello ", s2 = "world!", s3 = s1 + s2;
            Console.WriteLine(s3);
            
            object obj = "String Sample";
            //ConsoleWrite(obj);// compile error
            ConsoleWrite((string)obj); // correct

            dynamic dyn = "String Sample";
            ConsoleWrite(dyn); // correct
            dyn = 1;
            //ConsoleWrite(dyn);// Runtime Error

        }
    }
    
}
