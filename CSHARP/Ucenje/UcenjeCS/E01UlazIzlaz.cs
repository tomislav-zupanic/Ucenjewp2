using System.Threading.Channels;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {



            

            //Komentar kroz više linija - ne prporuča se 

            // ispisi različitih tipova podataka
            Console.WriteLine(7); // int
            Console.WriteLine(true); //bool
            Console.Write("Prvi"); // string
            Console.Write("Drugi"); // string
            Console.WriteLine(3.14); // float
            

            // varijabla je prostor u memoriji
            Console.Write("Unesi ime ovdje: ");
            string Ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste ime " + Ime);


            //// TIPIČAN PROGRAM IMA

            //ulaz
            Console.Write("Unesi visinu u centimetrima: ");
            int Visina = int.Parse(Console.ReadLine());


            //algoritam
            float VisinaUMetrima = (float)Visina / 100;

            //izlaz

            Console.WriteLine("Visoki ste " + VisinaUMetrima + " metara");



            ////Učitati decimalni broj i ispisati ga

            float DecimalniBroj = float.Parse(Console.ReadLine());
            Console.WriteLine(DecimalniBroj);

            // Program unosi dužinu i širinu prostorije
            // Program ispisuje površinu prostorije

            Console.Write("Unesi duzinu prostorije: ");
            float Duzina= float.Parse(Console.ReadLine());
            Console.Write("Unesi sirinu prostorije: ");
            float Sirina = float.Parse(Console.ReadLine());

            float Povrsina =Duzina * Sirina;
            Console.WriteLine("Povrsina prostorije je " + Povrsina);



        }

    }
}
