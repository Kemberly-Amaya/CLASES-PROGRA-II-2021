using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebASP.NetClase02.Models
{
    public class ClsPersona
    {    //Esto esta desligado de la db
        //Representacion de las clases es decir de las entidades de la db.
        //ViewModels ---->

        //
        public int Id { get; set;}

        public string Nombre { get; set; }
    }
}