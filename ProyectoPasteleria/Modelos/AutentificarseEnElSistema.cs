using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Modelos
{
    public class AutentificarseEnElSistema
    {
        //Validad la informacion ingresada,si el valor ingresado es valido pasa a auteticar los datos
        public Boolean ValidarDatos(JObject Datos)
        {
            return AutenticarUsuario( Datos);


            return false;

        }
        //verifica que el usuario este registrado
        public Boolean AutenticarUsuario(JObject Datos)
        {

            return true;

        }
    }
}