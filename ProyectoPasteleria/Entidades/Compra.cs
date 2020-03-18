using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Compra
    {
        private int Id;
        private DateTime Fecha;

        public Compra(int id, DateTime fecha)
        {
            Id = id;
            Fecha = fecha;
        }
    }

}