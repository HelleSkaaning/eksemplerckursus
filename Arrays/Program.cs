using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] salary = { 10000, 20000, 15000, 20000, 30000, 15000 };
                double total = 0;

                for (int i = 0; i < salary.Length; i++)
                {
                    Console.WriteLine("Månedsløn: " + salary[i].ToString("C2"));
                    total += salary[i];
                }

                Console.WriteLine("Total: " + total.ToString("C2"));
                double gnsnt = total / salary.Length;
                Console.WriteLine("Gnsnt: " + gnsnt.ToString("C2"));

                Console.WriteLine();
                Console.WriteLine();

                System.Array.Sort(salary);

                for (int i = 0; i < salary.Length; i++)
                {
                    Console.WriteLine(salary[i].ToString("C2"));
                }


                Console.WriteLine();
                Console.WriteLine();

                // hurtigere udgave:
                Console.WriteLine(salary.Sum());
                Console.WriteLine(salary.Average());
                string res = string.Join(",", salary);
                Console.WriteLine(res);

            }


            {
                string u = null;

                u = "Mikkel";
                Console.WriteLine(u.ToString());
                Console.WriteLine(u);

                string w = u + " \t\t***\r\n "+u;

                Console.WriteLine(w);

                string stiTilFil = @"c:\temp\trunte.txt";
                Console.WriteLine(stiTilFil);

                stiTilFil = "c:\\temp\\trunte.txt";
                Console.WriteLine(stiTilFil);

                Console.WriteLine(u.ToUpper());

                Console.WriteLine(u.Substring(2,3));

                Console.WriteLine();
                Console.WriteLine();


            }


            {

                string a = "";
                Console.WriteLine("Start");
                for (int i = 0; i < 1_000_000; i++)
                {
//                    a = a + '*'; // NEJ 

                }
                Console.WriteLine("Slut");

                System.Text.StringBuilder sb = new StringBuilder();
                Console.WriteLine("Start");
                for (int i = 0; i < 1_000_000; i++)
                {
                    sb.Append("*");
                }
                Console.WriteLine("Slut");


            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
