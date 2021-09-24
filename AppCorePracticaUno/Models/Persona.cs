using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCorePracticaUno.Models
{
    public class Persona
    {
        [Display(Name = "Nombre Usuario")]
        [Required(ErrorMessage = "Error, este campo es requerido")]
        public String NombreUsuario { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Error, este campo es requerido")]
        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Error, este campo es requerido")]
        public String Sexo { get; set; }

        [Display(Name = "Tipo de educacion")]
        [Required(ErrorMessage = "Error, este campo es requerido")]
        public String Tipodeeducacion { get; set; }

    }
}
