using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_ClaseSemana4.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            return View();
        }

        public ActionResult Recibo(String valorPorHora, String NombreEmpleado, String tiempoLabor, String horasDeTrabajo)
        {
            Double VporHora = Convert.ToDouble(valorPorHora);
            int time = Convert.ToInt32(tiempoLabor);
            int horasTrabajo = Convert.ToInt32(horasDeTrabajo);

            Double SueldoBruto = VporHora * time + horasTrabajo * 30;
            Double TotalDescuentos = ((VporHora * time + horasTrabajo * 30) * 0.13);
            Double SueldoConDescuentos = ((VporHora * time + horasTrabajo * 30) -
                                           (VporHora * time + horasTrabajo * 30) * 0.13);

            //Formularios: forma de traer la información de la vista hacia el back_ end

            //ViewBag : forma de llevar la información del back_ end hacia la vista

            ViewBag.nombre = NombreEmpleado;
            ViewBag.antiguedad= tiempoLabor;
            ViewBag.valorPHora = valorPorHora;
            ViewBag.SBruto = SueldoBruto;
            ViewBag.DesTotal = TotalDescuentos;
            ViewBag.SDesc= SueldoConDescuentos;

            return View();
        }
    }
    
}