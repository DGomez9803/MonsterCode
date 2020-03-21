using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Usuario
    {
        private int Id { get => Id; set => Id = value; }

        public String Nombre { get => Nombre; set => Nombre = value; }
        public String Apellido { get => Apellido; set => Apellido = value; }

        public String Correo_Electronico { get => Correo_Electronico; set => Correo_Electronico = value; }
        public String Contraseña { get => Contraseña; set => Contraseña = value; }
    }
}