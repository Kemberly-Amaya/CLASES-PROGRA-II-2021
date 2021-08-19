using AplicacionWebASP.NetClase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebASP.NetClase02.DAORE
{
    public class PersonaRepositorio
    {
        //Creando Lista de tres elementos
        public List<ClsPersona> obtenerPersona() {
            return new List<ClsPersona>()
            {
               
                new ClsPersona()
                {
                   Id = 1,
                   Nombre = "Jeremy"

                },
                 new ClsPersona()
                {
                   Id = 2,
                   Nombre = "Kemberly"

                },

                  new ClsPersona()
                {
                   Id = 3,
                   Nombre = "Arquimides"

                }
                  //Con el controlador mostramos la lista
            };
        }
    }
}