using AplicacionWebASP.NetClase02.DAORE;
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
        // GET: Persona                  //Query string
        public ActionResult Descripcion(String variable) 
        {
            //var person = new ClsPersona { Nombre = "Kemberly" };

            //Enviar elemento hacia la vista
            ViewBag.variabledinamica = variable;

            //return View(person);

            PersonaRepositorio per = new PersonaRepositorio();
            return View(per.obtenerPersona()); //Retornamos vista
        }
    }
}