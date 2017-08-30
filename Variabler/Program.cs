using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    enum Filtyper
    {
        csv,
        pdf,
        txt
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Int32 heltal = 10;
            Console.WriteLine(heltal.ToString());
            heltal++;
            Console.WriteLine("heltal++: "+heltal.ToString());
            heltal--;
            Console.WriteLine("heltal--: " + heltal.ToString());
            heltal += 20;
            Console.WriteLine("heltal+=20: " + heltal.ToString());


            double kommatal = 12.5;
            Console.WriteLine(kommatal.ToString());
            kommatal++;
            Console.WriteLine("kommatal++: " + kommatal.ToString());
            kommatal--;
            Console.WriteLine("kommatal--: " + kommatal.ToString());
            kommatal *= 2;
            Console.WriteLine("kommatal*=2: " + kommatal.ToString());

            Filtyper ft;
            ft = Filtyper.pdf;
            Console.WriteLine("filtype: "+ft.ToString());
            Console.WriteLine("Filværdi: ");
            Console.WriteLine((int)ft);

            DateTime d = DateTime.Now;
            Console.WriteLine("Date: " + d.ToString("ddMMyy"));
            Console.WriteLine("Date: "+d.ToString("ddddd d. MMMM yyyy"));
            Console.WriteLine("Date: " + d.ToString("ddMMyy hh:mm:ss"));

            Person p1;

            p1.Id = 1234567;
            p1.Navn = "Mikkel";
            Console.WriteLine("p1.navn: "+p1.Navn);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        
        }
    }
}
