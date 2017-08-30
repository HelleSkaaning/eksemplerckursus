using
    System;

namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {


                {

                    PersonStruct p1;
                    //p1.Id++;
                    p1.Id = 2;
                    p1.ErILive = true;

                    PersonStruct p2 = new PersonStruct(); // Brug det der new for at sikre at der er intialiseret
                    p2.Id++;
                    p2.Id = 2;
                    p2.ErILive = true;

                    System.Console.WriteLine(p1.Id);
                    System.Console.WriteLine(p2.Id);

                    p1 = p2; // kopierer værdier IKKE reference
                    p2.Id = 5;

                    System.Console.WriteLine(p1.Id);
                    System.Console.WriteLine(p2.Id);

                    // De fleste vil lave en klassse ikke en struct
                    // Der hvor man gerne vil kopiere værdier er det bedre at bruge structs
                    // struct er en mindre sammensat type

                    System.Console.WriteLine();

                    PersonClass p3;
                    p3 = new PersonClass();
                    p3.Id = 3;
                    p3.ErILive = true;
                    //System.Console.WriteLine(p3.Id);

                    PersonClass p4 = new PersonClass();
                    p4.Id = 4;
                    p4.ErILive = false;

                    System.Console.WriteLine(p3.Id);
                    System.Console.WriteLine(p4.Id);

                    p3 = p4; // så peger p3 reference nu på samme memory som p4
                    System.Console.WriteLine(p3.Id);
                    System.Console.WriteLine(p4.Id);
                }

                {

                    System.Console.WriteLine();
                    System.Console.WriteLine();

                    int[] i;
                    i = new int[5];

                    int[] x = new int[5];

                    x[0] = 2;
                    //x[0] = "dsfdsf"; NEJ!!!
                    x[1] = 3;
                    x[3] = 76;
                    //x[8] = 22; NEJ!!!!!

                    System.Console.WriteLine(x[0]);

                    System.Console.WriteLine(x);

                    for (int r = 0; r < x.Length; r++)
                    {
                        System.Console.WriteLine(x[r]);
                    }

                    System.Console.WriteLine();
                    System.Console.WriteLine();

                    int[] xx = { 2, 5, 0, 76, 0 };


                }


                {
                    int[] j = { 5, 3, 74 };
                    int[] x = { 7, 8, 1, 6, 5, 4 };

                    System.Console.WriteLine(j[1]);
                    System.Console.WriteLine(x[1]);
                    System.Console.WriteLine(j == x);
                    j = x; // Nu er de ens

                    System.Console.WriteLine(j[1]);
                    System.Console.WriteLine(x[1]);
                    System.Console.WriteLine(j == x);


                    System.Array.Sort(x);

                    System.Console.WriteLine();
                    System.Console.WriteLine(x.Length);
                }


            }

            int y = 0;
            bool f = false;

            if (y> 0 && f == true)
            {

            }
            else
            {
 
            }

            
            

            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }


    struct PersonStruct
    {
        public int Id;
        public bool ErILive;
    }

    class PersonClass
    {
        public int Id;
        public bool ErILive;
    }
}
