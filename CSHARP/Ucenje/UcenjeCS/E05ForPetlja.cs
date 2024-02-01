using System.Threading.Channels;

namespace UcenjeCS
{
    internal class E05ForPetlja
    {
        public static void Izvedi()
        {

            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");
            Console.WriteLine("Edunova");

            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Edunova");
            }

            int t;

            for (t = 0; t < 10; t++)
            {
                Console.WriteLine("Edunova t");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for( int i =0;i<20;i+=2)
            {
                Console.WriteLine(i);
            }

            for (int i = 3; i < 23; i+=2)
            {
                Console.WriteLine(i+1);
            }
            Console.WriteLine("*********************************");
            int b1 = 45;
            int b2 = 45;
            
            int manji = b1<b2?b1:b2;
            int veci = b1>b2?b1:b2;

            if (manji == veci && manji % 2 != 0) 
            {
                Console.WriteLine("isti brojevi nemaju parne");
            }

            for (int i = manji;i<= veci; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
                
            }




            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(string.Format("{0,-4}", (i + 1) * (j + 1)));


                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (; ; )
            {
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");

                break;
            }
            int broj;
            for (; ; )
            {
                Console.Write("Unesi broj izmedu 1 i 10: ");
                broj = int.Parse(Console.ReadLine());
                if ((broj >= 1) && (broj <= 10))
                {
                    break;
                }
                Console.WriteLine("Dragi korisnice krivi unos!");
            }
            Console.WriteLine(broj * broj);











        }
    }
}
