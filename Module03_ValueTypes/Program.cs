using System;

namespace Module03_ValueTypes
{
    enum Køn
    {
        Mand =1,
        Kvinde =2
    }


    struct Person
    {
        public string navn;
        public Køn køn;
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            {
                Person person1;

                person1.navn = "Mikkel";
                person1.køn = Køn.Mand;
            }

            {
                System.Int32 i;
                System.Decimal komma;

                int j; // normal integer
                decimal komma2; // normal brugt
                double d;
                long l;

                // timestamp = timeticks siden 1-1-01 eller ?
                System.DateTime dato = DateTime.Now;

                System.Boolean b;
                bool b1; // 0 eller 1

                // Mest brugte: int, decimal, bool, DateTime

                int u = 0; // ellers må du ikke bruge den
                u = u + 1;

                DateTime jul = new DateTime(2017, 12, 24);

                TimeSpan ts = jul.Subtract(dato);

                const int antalMånederPrÅr = 12;
                antalMånederPrÅr.ToString();

                //antalMånederPrÅr = 13; Man må ikke, det er en konstant
                Console.WriteLine(antalMånederPrÅr.ToString());


                Console.WriteLine(jul.ToString("dd. MMMM yy"));
            }

            {
                int i = 1;
                short s = 2;
                i = s;
                s = Convert.ToInt16(i); // Det er den mest normale at bruge - Man ønsker fejlhåndtering
                checked
                {
                    short l = (short)i;
                }

            }

            {
                // Første gang man bruger variablen får den en værdi basseet på aktuelle værdi
                var r = "gdksæk,æløf"; // Ikke god skik, brug
                string s = "sdafadfa";

                var t = Test();
                //t = "sdafafa"; Nej det må man ikke


            }

            {
                //System.ConsoleColor.Red

                // Sådan får man et køn omformuleret til en type
                Køn nytkøn = (Køn)Enum.Parse(typeof(Køn), "2");

                DayOfWeek d = DayOfWeek.Monday;
                Console.WriteLine(d);

                switch (d) // når man indsætter enum i switch og trykke ctrl+'.' så kan den foruddefinere hele switch
                {
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Monday:
                        break;
                    case DayOfWeek.Tuesday:
                        break;
                    case DayOfWeek.Wednesday:
                        break;
                    case DayOfWeek.Thursday:
                        break;
                    case DayOfWeek.Friday:
                        break;
                    case DayOfWeek.Saturday:
                        break;
                    default:
                        break;
                }





            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static double Test()
        {
             return 0.0;
        }
    }
}
