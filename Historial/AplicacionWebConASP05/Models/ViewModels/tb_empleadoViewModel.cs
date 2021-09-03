using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionWebASP.NetClase02.Models.ViewModels
{
    public class tb_empleadoViewModel
    {
        //Clase espejo
        //hacer validaciones desde aqui
        [Display(Name = "NOMBRE")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int idEmpleado { get; set; }
        public string Emple_Nombre { get; set; }
        public string Emple_DUI { get; set; }
        public string Emple_direccion { get; set; }
        public string Emple_tel { get; set; }
        public string Emple_email { get; set; }
        public string Emple_cargo { get; set; }

        //Constructor generado, este hará un casteo 
        public tb_empleadoViewModel(tb_empleado empleado)
        {
            this.idEmpleado = empleado.idEmpleado;
            Emple_Nombre = empleado.Emple_Nombre;
            Emple_DUI = empleado.Emple_DUI;
            Emple_direccion = empleado.Emple_direccion;
            Emple_tel = empleado.Emple_tel;
            Emple_email =empleado.Emple_email;
            Emple_cargo = empleado.Emple_cargo;
        }

        public tb_empleadoViewModel()
        {
        }
    }
}