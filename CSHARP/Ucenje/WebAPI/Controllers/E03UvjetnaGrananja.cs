using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnaGrananja:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public string Zad1(int broj)
        {
            //if (broj % 2 == 0)
            //{
            //    return "Paran";
            //}
            //else
            //{
            //    return "neparan";
            //}

            return broj % 2 == 0 ? "Paran" : "Neparan";
           
        
        }
        [HttpGet]
        [Route("zad2")]

        public string OcjenaTekstom(int Ocjena)
        {
            switch (Ocjena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odlican";
                default:
                    return "pogresan unos";

            }











            //return Ocjena == 1 ? "Nedovoljan" : "";
            //return Ocjena == 2 ? "Dovoljan" : "";
            //return Ocjena == 3 ? "Dobar" : "";
            //return Ocjena == 4 ? "Vrlo dobar" : "";
            //return Ocjena == 5 ? "Odlican" : "";
        }



    }
}
