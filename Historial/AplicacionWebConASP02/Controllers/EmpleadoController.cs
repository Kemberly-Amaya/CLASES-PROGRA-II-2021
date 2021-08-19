using AplicacionWebASP.NetClase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWebASP.NetClase02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {

            //Mostrar los datos de la base de datos hacemos lo siguiente

            //1° la conexión a la bd
            using (EmpleadoEntities empleado = new EmpleadoEntities())
            {

                //k 2° varibale var que contendra la lista empleado traida de la base de datos
                var listaempleado = empleado.tb_empleado.ToList();

                //retornar vista
                return View(listaempleado);

            }

        }

        public ActionResult Delete(int Id) {

            using (EmpleadoEntities empleadoDb = new EmpleadoEntities())
            {
                //Se busca el id traido desde el front- End hacia 
                //el backe-end la db 

                tb_empleado EliminarEmpleado = empleadoDb.tb_empleado.Where
                    (x => x.idEmpleado == Id).FirstOrDefault();

                empleadoDb.tb_empleado.Remove(EliminarEmpleado);
                empleadoDb.SaveChanges();
            }

            //Redireccionar Vista Redirect("/Nombre Controlador/ Nombre Vista");
                return Redirect("/Empleado/Empleado");
        }

        [HttpPost]
        public ActionResult Save(String Nombre, String DUI, String Direccion,
          String  Telefono, String Correo, String Cargo) {

            using (EmpleadoEntities empleadoDb = new EmpleadoEntities())
            {
                tb_empleado Tb = new tb_empleado();
                Tb.Emple_Nombre = Nombre;
                Tb.Emple_DUI = DUI;
                Tb.Emple_direccion = Direccion;
                Tb.Emple_tel = Correo;
                Tb.Emple_cargo = Cargo;

                empleadoDb.tb_empleado.Add(Tb);
                empleadoDb.SaveChanges();
            
            
            }

                return Redirect("/Empleado/Empleado");
        
        
        }
        public ActionResult Registro() {
            return View();
        }
    }
}