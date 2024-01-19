using System.Reflection.Metadata;

namespace UcenjeCS
{
    internal class E03UvjetnaGrananja
    {
        public static void Izvedi()
        {
            int i = 7;

            bool Uvjet = i == 7;

            if (Uvjet)
            {
                Console.WriteLine($"broj je {i} usao sam u true dio if naredbe");
            }

            if (i == 7)
            {
                Console.WriteLine("isti uvjet kao i prethodno");
            }

            if (i < 5)
            {
                Console.WriteLine("i je manji od 5");
            }
            else
            {
                Console.WriteLine("i nije manji od 5");
            }

            if (i == 2)
            {
                Console.WriteLine("i je 2 ");
            }
            else if (i == 3)
            {
                Console.WriteLine(3);

            }
            else
            {
                Console.WriteLine("i niti je 2 niti  je 3");
            }
            int j = 2;
            if (i == 7)
            {
                if (j == 2)
                {
                    Console.WriteLine("Oba uvjeta su zadovoljena ugnjezdena");
                }
            }
            i = 5;
            if (i == 7 & j == 2)
            {
                Console.WriteLine("oba uvjeta zadovoljena");
            }
            if (i == 7 && j == 2)
            {
                Console.WriteLine("oba uvjeta zadovoljena");
            }
            if (i == 5 | j == 1)
            {
                Console.WriteLine("dovoljno je jedan uvjet");

            }
            if (i == 5 || j == 2)
            {
                Console.WriteLine("oba uvjeta zadovoljavaju");
            }
            if ((i == 5 || j == 1) && !(i > 5 || j < 8))
            {
                Console.WriteLine("komplicirani izraz");
            }

            int cb=int.Parse(Console.ReadLine());

            if (cb > 10)
            {
                Console.WriteLine("Osijek");
            }
            else
            {
                Console.WriteLine("Zagreb");
            }

            Console.WriteLine(cb>10 ? "Osijek" : "Zagreb");


            int ocjena = 4;

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("nedovoljan");
                    break;    
                case 2:
                    case 3:
                    Console.WriteLine("dovoljno ili dobro");
                    break;
                case 4: case 5:
                    Console.WriteLine("to je ocjena");
                    break;
                default:
                    Console.WriteLine("nije ocjena");
                    break;
            }

            string ime = "Pero";

            switch (ime)
            {
                case "Marko":
                    Console.WriteLine("OK");
                    break;
                case "Pero":
                    Console.WriteLine("SUPER");
                    break;


            }




        }   
    }
}
