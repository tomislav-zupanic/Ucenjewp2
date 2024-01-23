using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01 : ControllerBase
    {
        [HttpGet]
        [Route("vjezba1")]

        public string Vjezba1(int b1, int b2, string o)
        {
            int rezultat = 0;
            switch (o)
            {
                case "+":
                    rezultat = (b1 + b2);
                    break;
                case "-":
                    rezultat = (b1 - b2);
                    break;
                case "*":
                    if (b1 != 0)
                    {
                             if (b2 != 0)
                             {
                             rezultat = (b1 * b2);
                             }
                             else
                             {
                             return "Nije moguce mnoziti sa 0";
                             }
                             break;


                    rezultat = (b1 * b2);
                    }
                    else
                    {
                        return "Nije moguce mnoziti sa 0";
                    }
                    break;
                    
                case "/":
                    if (b2 != 0)
                    {
                        rezultat = (b1 / b2);
                    }
                    else
                    {
                        return "Nije moguce dijeliti sa 0";
                    }
                    break;
                default:
                    return "Krivi unos";

            }
            string KonacniRezultat = rezultat.ToString();
            return KonacniRezultat;
        }


        [HttpPost]
        [Route("Vjezba2")]
        public double Vjezba2(double[] Brojevi)
        {
            double PB = Brojevi.First();
            double DioPrvog = (int)(PB / 1);
          
            double ZB =Brojevi.Last();
            double DioZadnjeg = (double)(ZB % 1);

            double Rezultat = DioPrvog + DioZadnjeg;

            return Rezultat;
        }




    }
}
