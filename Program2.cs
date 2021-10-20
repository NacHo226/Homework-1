using System;

namespace ConsoleApp2
{
    class Program
    {
        // базовый класс
        class A
        {
            public int a;
        }

        // класс B наследует A
        class B : A
        {
            public int b;
        }

        // класс C наследует B
        class C: B
        {
            public int c;
        }
        
        public class Base { }

        public class Derived : Base { }
        static void Main(string[] args)
        {
            string name1 = @"c:\Мои Документы\заметка.txt";
            int g = 18;
            Console.WriteLine($"Указанный возраст {g} лет.");// output: Указанный возраст 18 лет.
            int i = 3;
            Console.WriteLine(i++);          // output: 3
            double a = 1.5;
            Console.WriteLine(++a);          // output: 2.5
            Console.WriteLine(i--);          // output: 4 
            Console.WriteLine(-a);           // output: -2.5
            Console.WriteLine(i * a);        // output: 7.5
            Console.WriteLine(i / a);        // output: 1.2
            int x = 14;
            double y = 12.5;
            double max;
            Console.WriteLine(max = x > y ? x : y);//output 14
            //string format
            double number2 = 45.08;
            string result2 = String.Format("{0:f4}", number2);
            Console.WriteLine(result2);     // output 45,0800
            decimal number = 0.15345m;
            Console.WriteLine("{0:P1}", number);// output 15.3%
            
            Console.WriteLine(10 / 5);       // output: 2
            Console.WriteLine(5 % 4);        // output: 1
            Console.WriteLine(50.3 % 4.2);   // output: 4,099999999999995
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
            object b = new Base();
            Console.WriteLine(b is Base);    // output: True
            Console.WriteLine(b is Derived); // output: False
            
            // объекты классов A, B, C
            A objA = new A();
            B objB = new B();
            C objC = new C();

            // попробовать выполнить приведение типов, если возможно
            // в obj заносится результат приведения объекта obj
            objB = objA as B;

            if (objB == null)
                Console.WriteLine("Невозможно привести objA к типу B");
            else
                Console.WriteLine("Можно приводить objA к типу B");

            // еще одна попытка привести objC к типу B, результат в objB
            objB = objC as B;

            // вывод результата
            if (objB == null)
                Console.WriteLine("Невозможно привести objC к типу B");
            else
                Console.WriteLine("Можно приводить objC к типу B");
            //type cast
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
        
    }
}
