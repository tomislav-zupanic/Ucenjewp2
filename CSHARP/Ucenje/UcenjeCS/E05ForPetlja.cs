namespace UcenjeCS
{
    internal class E05ForPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");


            for(int i= 0;i<10;i++)
            {
                Console.WriteLine("Edunova");
            }

            int t;
            for (t = 0; t < 10; t++)
            {
                Console.WriteLine("Edunova T");
            }

            for( int i =0; i<10; i++)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }


            for (int i=0 ; i < 20;i += 2)
            {
                Console.WriteLine(i);
            }



            int ukpb = 44;
            int ukdb = 44;


            int manji = ukpb < ukdb ? ukpb : ukdb;         
            int veci =ukdb > ukpb ? ukdb : ukpb;

            if (manji == veci && manji%2!=0)
            {
                Console.WriteLine("Unjeli ste iste brojeve,nema ispisa brojeva");
            }

            for (int i = manji; i <= veci; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    int rezultat = i * j;
                    Console.Write(rezultat.ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            for(int i = 0; i < 10; i++)
            {
                if(i % 3 == 0)
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
