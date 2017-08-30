using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine(i);
            Test1();
            Test2(12);

            int x = 0;
            Console.WriteLine(x);
            Test4(x);
            Console.WriteLine(x);


            int res = Test3(3, 5);


            Console.WriteLine();
            Console.WriteLine();

            int t = 4;
            Console.WriteLine(t);
            Test6(ref t);
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine();


            double r = 0;
            int res1 = Test7(5, 2, ref r); // Så kan man gøre flere ting i samme funktion....


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        static int Test7(int a, int b, ref double gns)
        {
            gns = (a + b) / 2;

            return a + b;


        }

        static void Test1()
        {
            int i = 1;
            Test2(i);
        }
        static void Test2(int y)
        {
            Console.WriteLine(y);
            if (y > 5)
            {
                return;
            }
            int i = 1;
        }

        static  int Test3(int a, int b)
        {
            return a + b;
        }

        static void Test4(int x)
        {
            x = 10000;
        }


        // Prøv at lave en metode, der tager en type Person som ind parameter og kalder den udefra hvor den ændrer.
        // Se at så ændres objekt udenfor da det er referenceobjekter.


        static void Test6(ref int x)
        {
            x = x * 2;

        }

    }
}
