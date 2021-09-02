using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebASP.NetClase02.Models.ViewModels
{
    public class tb_empleadoViewModel
    {
        //Clase espejo
        public int idEmpleado { get; set; }
        public string Emple_Nombre { get; set; }
        public string Emple_DUI { get; set; }
        public string Emple_direccion { get; set; }
        public string Emple_tel { get; set; }
        public string Emple_email { get; set; }
        public string Emple_cargo { get; set; }
    }
}