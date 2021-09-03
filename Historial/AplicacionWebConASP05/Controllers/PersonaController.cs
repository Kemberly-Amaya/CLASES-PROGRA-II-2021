using AplicacionWebASP.NetClase02.DAORE;
using AplicacionWebASP.NetClase02.Models;
using AplicacionWebASP.NetClase02.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWebASP.NetClase02.Controllers
{
    
    public class PersonaController : Controller
    {
        //Aqui se recibirá toda la información

        // GET: Persona                  //Query string
        public ActionResult Descripcion(/*String variable*/) 
        {
            ////var person = new ClsPersona { Nombre = "Kemberly" };

            ////Enviar elemento hacia la vista
            //ViewBag.variabledinamica = variable;

            //return View(person);
            return View();

            //PersonaRepositorio per = new PersonaRepositorio();
            //return View(per.obtenerPersona()); //Retornamos vista
        }

           //Se estan recibiendo todos los datos que vienen desde la vista  //Objeto de la clase espejo ---ahi estan las validaciones
        public ActionResult DescripcionViewModels(PersonaViewModel persona) {


            if (!ModelState.IsValid) { //--> !ModelState servira para los viewmodels traigan datos válidos

                //Enviar al controlador pero tambien cargar los datos que traia de persona
                return View("PersonaViewModel", persona); //Retornar a la vista, se dirige a una accion 
                                                //obejeto de "persona" ahi se encuentrn los datos cap
            }

            //Si todo es funcional dirige a la página
            return Redirect("PersonaViewModel"); //se dirige directamente hacia la pagina

        }
        public ActionResult PersonaViewModel() {
            return View();
        }
    }
}