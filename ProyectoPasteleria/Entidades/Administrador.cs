using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Administrador
    {

        
        public int Id { get => Id; set => Id = value; }
        public String Area { get => Area; set => Area = value; }

        //constructor de la clase administrador
        public Administrador(int id, string area)
        {
            Id = id;
            Area = area;
        }
      

        //Metodo que usa el administrado para notifica perdido exitoso
        public void NotificarPedidoExitoso()
        {

        }
    }
}