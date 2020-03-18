using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Catalogo
    {
        private int Id;
        private String Nombre;
        private Pastel[] Pasteles;

        public Catalogo( int  id,string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public String GetNombre()
        {
            return Nombre;
        }
         public Pastel[] GetPasteles()
        {
            return Pasteles;
        }

        //Genera un json con toda la informacion de Catalogo con sus pasteles
        public JObject GetCatalogo()
        {
            JObject Datos = new JObject();

            Datos = new JObject(
        new JProperty("Catalogo",
            new JObject(
                new JProperty("Id", Id),
                new JProperty("Nombre", Nombre),
                new JProperty("Pasteles",
                    new JArray(
                        from pastel in Pasteles
                        select new JObject(

                           new JProperty("Id", pastel.GetDatos().GetValue("Id")),
                         new JProperty("Nombre", pastel.GetDatos().GetValue("Nombre")),
                         new JProperty("Peso", pastel.GetDatos().GetValue("Peso")),
                         new JProperty("Categoria", pastel.GetDatos().GetValue("Categoria")),
                         new JProperty("Precio", pastel.GetDatos().GetValue("Precio")),
                         new JProperty("Descripcion", pastel.GetDatos().GetValue("Descripcion")),
                         new JProperty("Imagen", pastel.GetDatos().GetValue("Imagen"))
                                ))))));

            return Datos;
        }

    }
}