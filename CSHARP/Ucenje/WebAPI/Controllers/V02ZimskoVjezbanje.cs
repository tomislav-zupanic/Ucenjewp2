using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]

        public int Zadatak1()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            return suma;
        }

        [HttpGet]
        [Route("zad2")]

        public int[] Zadatak2()
        {
            int[] Niz = new int[28];
            int broj = 0;

            for (int i = 2; i <= 57; i += 2)
            {
                Niz[broj] = i;
                broj++;
            }

            return Niz;
        }


        [HttpGet]
        [Route("zad3")]

        public int Zadatak3()
        {
            int Zbroj = 0;
            for (int i = 2; i <= 18; i += 2)
            {

                Zbroj += i; //zbroj++

            }
            return Zbroj;
        }


        [HttpGet]
        [Route("zad4")]

        public int Zadatak4(int broj)
        {
            int Zbroj = 0;
            for (int i = 1; i <= broj; i++)
            {
                Zbroj++; // zbroj = zbroj + i
            }
            return Zbroj;
        }

        [HttpGet]
        [Route("zad5")]

        public int[] Zadatak5(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);
            int veciBroj = Math.Max(broj1, broj2);

            int duljinaNiza = (veciBroj - manjiBroj + 1) / 2;

            int[] parniBrojevi = new int[duljinaNiza];

            int indeks = 0;

            for (int i = manjiBroj; i <= veciBroj; i++)
            {
                if (i % 2 == 0)
                {
                    parniBrojevi[indeks] = i;
                    indeks++;
                }
            }
            return parniBrojevi;
        }

        [HttpGet]
        [Route("zad6")]

        public int[] Zadatak6(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);
            int veciBroj = Math.Max(broj1, broj2);

            int duljinaNiza = (veciBroj - manjiBroj + 1) / 2;

            int[] neparniBrojevi = new int[duljinaNiza];

            int indeks = 0;

            for (int i = manjiBroj; i <= veciBroj; i++)
            {
                if (i % 2 != 0)
                {
                    neparniBrojevi[indeks] = i;
                    indeks++;
                }
            }

            return neparniBrojevi;
        }

        [HttpGet]
        [Route("zad7")]

        public int Zadatak7(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);
            int veciBroj = Math.Max(broj1, broj2);

            int suma = 0;

            for (int i = manjiBroj; i <= veciBroj; i++)
            {
                suma += i;
            }
            return suma;
        }

        [HttpGet]
        [Route("zad8")]

        public int Zadatak8(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);
            int veciBroj = Math.Max(broj1, broj2);

            int suma = 0;

            for (int i = manjiBroj; i <= veciBroj; i++)
            {
                if (i % 3 == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }

        [HttpGet]
        [Route("zad9")]

        public int Zadatak9(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);
            int veciBroj = Math.Max(broj1, broj2);

            int suma = 0;

            for (int i = manjiBroj; i <= veciBroj; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        suma += i;
                    }
                    suma += i;
                }
            }
            return suma;
        }
        [HttpGet]
        [Route("zad10")]

        public string Zadatak10(int broj1, int broj2)
        {
            int[,] Tablica = new int[broj1, broj2];
            StringBuilder Rezultat = new StringBuilder();

            for (int i = 1; i <= broj1; i++)
            {
                for (int j = 1; j <= broj2; j++)
                {
                    Tablica[i - 1, j - 1] = i * j;
                    Rezultat.Append(Tablica[i - 1, j - 1] + "\t");
                }
                Rezultat.AppendLine();
            }

            return Rezultat.ToString();
        }
        [HttpGet]
        [Route("zad11")]

        public int[] Zadatak11(int broj)
        {
            int[] Redoslijed = new int[broj];

            for (int i = 0; i < broj; i++)
            {
                Redoslijed[i] = broj - i;
            }

            return Redoslijed;
        }
        [HttpGet]
        [Route("zad12")]

        public bool Zadatak12(int broj)
        {
            if (broj < 2)
            {
                return false; 
            }
            for (int i = 2; i <= Math.Sqrt(broj); i++)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }
            return true; 
        }
        [HttpGet]
        [Route("zad13")]
        public int[,] CiklicnaMatrica(int redovi, int stupci)
        {
         
        }
    }
}
