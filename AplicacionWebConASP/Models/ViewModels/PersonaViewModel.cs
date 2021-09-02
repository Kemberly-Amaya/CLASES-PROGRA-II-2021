using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionWebASP.NetClase02.Models.ViewModels
{
    //Esta clase hace referencia a los atributos que se encontraban en la 
    // clase de Persona, tambien servirá como validador de datos.

    public class PersonaViewModel
    {
        //"Clase espejo"

        //Validaciones solo en las clases espejos, y no directamente dentro de las clases
        //descriptoras de la db

        //Servira como validador de datos


        //Validaciones
                   //asi aparecera el atributo en la vista
        [Display (Name ="ID")]//---> estandar del emsamblaje de dataanotation
        [Range(0, int.MaxValue, ErrorMessage ="no valido")]//--> asosiación para que la informacion llegue de manera idonea
        // Rango, 0, desde el cero hasta un int, no acepta decimales

        //Atributos de la clase Persona
        public int Id { get; set; }   //----->Estatuto

        // estatutos estarán ligados
        //dentro de los controladores

        //Validaciones ---apareceran mensajes
        //asi aparecera el atributo en la vista
        [Display (Name ="NOMBRE")]  
        [Required(ErrorMessage ="Este campo es requerido")]   //Exigir el atributo desde el controller mediante el required
        public String Nombre { get; set; } //----->Estatuto
    }
}