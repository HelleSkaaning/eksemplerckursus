using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string navn = "";

            Console.WriteLine("Indtast navn");
            navn = Console.ReadLine();
            navn = navn.ToUpper();

            Console.WriteLine("Velkommen "+navn.ToLower());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Tryk på en tast for at fortsætte . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
