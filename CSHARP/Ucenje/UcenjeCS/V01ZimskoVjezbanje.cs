

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("********************");
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i );
            }

            Console.WriteLine("********************");


            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

            Console.WriteLine("********************");



            int Pokusaji=0 ;
            for(; ; )
            {

                Console.WriteLine("Unesi  broj veci od 100: ");         
                int Broj = int.Parse(Console.ReadLine());
                if (Broj <= 100)
                {
                   Pokusaji++;
                }
                else
                {
                    Console.WriteLine($"Pokusali ste unjeti broj koji je manji od 100  {Pokusaji} puta");
                }
         
                Console.WriteLine();

            }









        }




    }
}
