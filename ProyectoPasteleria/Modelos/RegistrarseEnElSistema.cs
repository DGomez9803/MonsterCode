using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Modelos
{
    public class RegistrarseEnElSistema
    {


        //Validad la informacion ingresada,si el valor ingresado es valido pasa a auteticar los datos
        public Boolean ValidarDatos(JObject Datos)
        {
            return RegistraDatos(Datos);


            return false;

        }
        //Registra los datos de usuario en la base de datos
        public Boolean RegistraDatos(JObject Datos)
        {
            return true;

        }
    }
}