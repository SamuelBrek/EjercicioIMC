using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioIMC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMController : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCResultado(double altura, double peso)
        {
            var Person = new Persona();
            Person.peso = peso;
            Person.altura = altura / 100;
            var AFinal = Person.altura;
            var IMC = peso / (AFinal * AFinal);
            var ComCorporal = "";
            if (IMC < 18.5)
            {
                ComCorporal = "Tienes un peso inferior a lo normal";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    ComCorporal = "Tienes un peso normal";
                }
                else
                {
                    if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        ComCorporal = "Tienes un peso superior al normal";
                    }
                    else
                    {
                        ComCorporal = "Tienes obesidad";
                    }
                }
            }
            var Resultado = "Su IMC es: " + Convert.ToString(IMC) + "y su composicion corporal es: " + ComCorporal;
            return Ok(Resultado);
        }
    }

 }


    

