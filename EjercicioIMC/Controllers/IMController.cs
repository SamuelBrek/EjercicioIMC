using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Ejercicio 3: Anagramas
Nombre del alumno: Brek Mejia Samuel Alexander
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/


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


    

