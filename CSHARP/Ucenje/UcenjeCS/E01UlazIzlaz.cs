﻿
namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
            {

            //Console.WriteLine(7);
            //Console.WriteLine(true);
            //Console.Write("Prvi");
            //Console.Write("Drugi");
            //Console.WriteLine(3.14);
            //Console.Write("Unesi ime: ");
            //string ime = Console.ReadLine();

            //Console.WriteLine("Unijeli ste " + ime);

            //Console.Write("Unesi visinu u centrimentrima: ");
            //int Visina = int.Parse(Console.ReadLine());

            //float VisinaUMetrima = (float)Visina / 100;

            //Console.WriteLine("Visoki ste " + VisinaUMetrima + "metara");

            //int Broj = int.Parse(Console.ReadLine());
            //Console.WriteLine((float)Broj);

            Console.Write("Unesi dužinu prostorije: ");
            float Duzina = float.Parse(Console.ReadLine());

            Console.Write("Unesi širinu prostorije: ");
            float Sirina = float.Parse(Console.ReadLine());

            var Povrsina = Duzina * Sirina;

            Console.WriteLine(Povrsina);



        }
    }
}
