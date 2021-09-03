using AplicacionWebASP.NetClase02.Models;
using AplicacionWebASP.NetClase02.Models.ViewModels;
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

        public ActionResult Save(tb_empleadoViewModel emple) { //enviando peticion con el modelo completo
          
            using (EmpleadoEntities empleDb = new EmpleadoEntities())
            {
                tb_empleado Tb = new tb_empleado();//Esto es entity framework

                if (emple.idEmpleado == 0)
                {
                    Tb.Emple_Nombre = emple.Emple_Nombre;//eto es viewmode, y en el template se captura el viemw model
                    Tb.Emple_DUI = emple.Emple_DUI;
                    Tb.Emple_direccion = emple.Emple_direccion;
                    Tb.Emple_tel = emple.Emple_tel;
                    Tb.Emple_email = emple.Emple_email;
                    Tb.Emple_cargo = emple.Emple_cargo;

                    empleDb.tb_empleado.Add(Tb);
                    empleDb.SaveChanges();


                }
                else {
                    int idupdate = emple.idEmpleado;
                    tb_empleado editar = empleDb.tb_empleado.Where(x => x.idEmpleado == idupdate).FirstOrDefault();
                    editar.Emple_Nombre = emple.Emple_Nombre;

                    empleDb.SaveChanges();

                }
                

                
            
            
            }

            //Referencia a la vista de empleado
                return Redirect("/Empleado/Empleado");
        
        
        }
        public ActionResult Registro (String id) {
            //enviar clase completa
            tb_empleado Tb = new tb_empleado();//Esto es entity framework
            using (EmpleadoEntities empleDb = new EmpleadoEntities())
            {
                
                int idupdate = Convert.ToInt32(id);

                tb_empleado cargardato = empleDb.tb_empleado.Where(x => x.idEmpleado == idupdate).FirstOrDefault();

                tb_empleadoViewModel pasandoDatos = new tb_empleadoViewModel(cargardato);


                return View(pasandoDatos);
            }
        }

        public ActionResult Edit(int id) {

            //pasando id hacia la parte del fron- end
            ViewBag.id = id;

            return View();
        }
    }
}