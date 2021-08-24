using Practica_ClaseSemana4.DaoRe;
using Practica_ClaseSemana4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_ClaseSemana4.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Usuario (string Usuario, String Pass) {

            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.nombre = Usuario;
            ObjUsuario.pass = Pass;


            UsuarioRepository repository = new UsuarioRepository();


            for (int i = 0; i<repository.pass.Length; i++) {
            if(ObjUsuario.pass.Equals(repository.pass[0]) && ObjUsuario.nombre.Equals(repository.user[0])) {

                    //Dentro de una estructura condicional el método no lo detecta --- fuera de rango
                    return Redirect("/Empleado/Empleado");
                }
           }
            //Los métodos deben tener un return --- siempre 
            //sino se cumple la condición se retorna a la vista
            return View(); //retornar vista en la que se está
        }

    }   
}