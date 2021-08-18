using AplicacionWebASP.NetClase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWebASP.NetClase02.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Descripcion()
        {
            var person = new ClsPersona { Nombre = "Kemberly" };
            return View(person);
        }
    }
}