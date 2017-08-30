using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum=0;
            string outStr = "";
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    sum = j * i;
                    outStr = sum.ToString();
                    //outStr = (j * i).ToString();
                    if (sum < 50)
                    {
                        System.Console.ForegroundColor = ConsoleColor.White;
                        System.Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.BackgroundColor = ConsoleColor.Blue;
                    }


                    Console.Write(outStr.PadLeft(4));

                }
                Console.WriteLine();
            }

            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
