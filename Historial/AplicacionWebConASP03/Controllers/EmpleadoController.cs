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
        //Recibir los párametros a utilizar que vienen a traves del Post ---> Petición 
        public ActionResult Save(int id,String Nombre, String DUI, String Direccion,
          String  Telefono, String Correo, String Cargo) {
          
            using (EmpleadoEntities empleDb = new EmpleadoEntities())
            {
                tb_empleado Tb = new tb_empleado();

                if (id == 0)
                {
                    Tb.Emple_Nombre = Nombre;
                    Tb.Emple_DUI = DUI;
                    Tb.Emple_direccion = Direccion;
                    Tb.Emple_tel = Telefono;
                    Tb.Emple_email = Correo;
                    Tb.Emple_cargo = Cargo;

                    empleDb.tb_empleado.Add(Tb);
                    empleDb.SaveChanges();


                }
                else {
                    int idupdate = id;
                    tb_empleado editar = empleDb.tb_empleado.Where(x => x.idEmpleado == idupdate).FirstOrDefault();
                    editar.Emple_Nombre = Nombre;

                    empleDb.SaveChanges();

                }
                

                
            
            
            }

            //Referencia ala vista de empleado
                return Redirect("/Empleado/Empleado");
        
        
        }
        public ActionResult Registro (String nombre, int id=0) {

            ViewBag.id = id;
            ViewBag.nombre = nombre;
            return View();
        }

        public ActionResult Edit(int id) {

            //pasando id hacia la parte del fron- end
            ViewBag.id = id;

            return View();
        }
    }
}