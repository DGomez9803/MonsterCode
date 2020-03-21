using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Modelos
{
    public class MediosPago:Entidad
    {
        public String Nombre { get => Nombre; set => Nombre = value; }

        public String Descripcion { get => Descripcion; set => Descripcion = value; }
    }
}