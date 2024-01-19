using Microsoft.AspNetCore.Connections.Features;
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
        public float Zad2(int i,int j)
        {
            return ((float)i / j);
        }

        [HttpGet]
        [Route("zad3")]
        public float Zad3(int i, int j)
        {
            //return ((float)i * j) + ((float)i /j);  //moj nacin


            var Umnozak = j * i;
            var Kvocijent = (float)i / j;
            return (Umnozak + Kvocijent);
        }

        [HttpGet]
        [Route("zad4")]
        public string Zad4(string s, string s1)
        {
            return (s + s1);
        }
        [HttpGet]
        [Route("zad5")]
        public bool IstiSu(int a, int b)
        {
            return a == b;
        }

    }
}
