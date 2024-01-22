using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E05")]
    public class E05ForPetlja:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int[] Zad1( int brojevi)
        
        
        {
            int[] Niz=new int[brojevi];

            for(int i = 0; i < brojevi; i++)
            {
                Niz[i] = i+1;
            }

            return Niz;
        }
        [HttpGet]
        [Route("zad2")]

        public int ZbrojBrojeva(int broj)

     
        {
            int suma = 0;
            for (int i = 1; i <= broj; i++)
            {
            suma += i;
            }

            return suma;
        }

        [HttpGet]
        [Route("zad3")]

        public int ZbrojBrojeva2(int broj)


        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                suma += i;
            }

            return suma;
        }






    }
}
