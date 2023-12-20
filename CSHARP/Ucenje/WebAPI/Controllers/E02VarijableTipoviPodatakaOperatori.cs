using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            // vratite najmanji broj
            return int.MinValue;
        }

        [HttpGet]
        [Route("zad2")]
        public float Zad2(int i, int j)
        {
            // Ruta vraća kvocijent dvaju primljenih brojeva
            return (float)i / j;
        }
        [HttpGet]
        [Route("zad3")]
        public float Zad3(int i, int j)
        {
            // Ruta vraća zboj umožak i kvocijent 2 broja
            //return ((float)i * j) + ((float)i / j);,isto funkcionira
            var umnozak = i * j;
            var kvocijent = (float)i / j;
            return umnozak + kvocijent;
        }
        [HttpGet]
        [Route("zad4")]
        public string Zad4(string s, string s1)
        {
            // Ruta vraća spojene primljene znakove
            return s + s1;

        }
        [HttpGet]
        [Route("zad5")]

        public bool IstiSu(int a, int b) 
        {
            Console.WriteLine("a={0}",a);
            //ruta vraca true ako je a jednako b,inace vraca false

            return a == b;
        }

    }

}
