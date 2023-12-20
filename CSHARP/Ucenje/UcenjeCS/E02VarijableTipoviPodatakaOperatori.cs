

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        internal static void Izvedi()
        {
            int Varijabla = 3;

            Console.WriteLine(Varijabla);

            int i=1, j=0, k;

            Console.WriteLine("{0},{1}",i,j);

            bool Istina = i == 1;

            Console.WriteLine(Istina);

            double Broj = 4.89;

            decimal VeciBroj = 2.89M;

            Console.WriteLine(int.MaxValue);
            int Mb = int.MaxValue;
            Console.WriteLine(Mb+1);

            i = 3; j = 2; k = 1;

            Console.WriteLine(i + j);
            Console.WriteLine(i-j);
            Console.WriteLine(i*j);
            Console.WriteLine(i/j);//kad djelimo dobijemo cijeli broj
            Console.WriteLine((float)i/j); //decimalni oblik rezultat

            int Db = 56;
            Console.WriteLine(Db/10);// ispisuje prvu znamenku

            bool Uvjet = i > j;
            Uvjet = i >= j;
            Uvjet = i <=j;
            Uvjet = i < j;
            Uvjet =i ==j;// provjera jednakosti
            Uvjet = i != j;//provjera ne jednakosti


            // operator modulo
            //ostatak od cjelobrojnog djeljenja


            int ostatak = 9 % 2;

            //dvoznamenkasti broj ispisi vrijednost jedinice

            Console.WriteLine(52% 10);


            i = 1;
            Console.WriteLine(i); //prvo racunanje je 1
            i = i + 1;//uvecanje od 1
            Console.WriteLine(i);//drugo racunanje je 2
            i += 1;//uvecanje od 1
            Console.WriteLine(i);//trece racunanje je 3 (svako racunanje se pamti i nadodaje)
            i++;//uveca za 1
            Console.WriteLine(i);//4

            //specs incrementa ++
            Console.WriteLine(i++); //korisit pa uveca i++, i nam je sada 5

            Console.WriteLine(i);//5
            //++i uveca pa korisiti

            Console.WriteLine(++i);//6
            Console.WriteLine(i);//6

            //dekrementi(isto sve vrijedi)

            int t = 1, l = 2;

            t = ++t - l;//t je 0, l je 2
            Console.WriteLine("t = ++t - l => t={0}, l={1}", t, l);
            l -= t - l;//t je 0 ,l je 4
            Console.WriteLine("l -= t - l => t={0}, l={1}", t, l);

            Console.WriteLine("++t - --l => t={0}, l={1}", t, l);
            Console.WriteLine(++t - --l);


            int s = 3, p = 1;
            s += -s + p;// s je 1, p je 1
            Console.WriteLine("s += -s + p => s={0}, p={1}",s,p);
            p = ++p +s;// P je 3 , s je 1
            Console.WriteLine("p = ++p + s => s={0}, p={1}", s, p);

            Console.WriteLine("--s + ++p => s={0}, p={1}", s, p);
            Console.WriteLine(--s + ++p);












        }
    }
}
