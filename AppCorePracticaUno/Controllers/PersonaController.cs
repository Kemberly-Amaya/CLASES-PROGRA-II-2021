using AppCorePracticaUno.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCorePracticaUno.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Persona persona)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }
            else
            {
                return View("Index", persona);
                
            }
        }

        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
