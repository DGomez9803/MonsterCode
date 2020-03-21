using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ProyectoPasteleria.Modelos
{
    public class Pastel:Entidad
    {

        public String Nombre { get => Nombre; set => Nombre = value; }
        public double Peso { get => Peso; set => Peso = value; }
        public String Categoria { get => Categoria; set => Categoria = value; }
        public double Precio { get => Precio; set => Precio = value; }
        public String Descripcion { get => Descripcion; set => Descripcion = value; }
        public Image Imagen { get => Imagen; set => Imagen = value; }
        public int IdCatalogo { get => IdCatalogo; set => IdCatalogo = value; }
        //constructor de la clase paatel
     
      


       
        
        //Genera un json con toda la informacion de pastel
        public JObject GetDatos()
        {
            JObject Datos = new JObject();

             Datos = new JObject(
                        // new JProperty("Id", Id),
                         new JProperty("Nombre", Nombre),
                         new JProperty("Peso", Peso),
                         new JProperty("Categoria", Categoria),
                         new JProperty("Precio", Precio),
                         new JProperty("Descripcion", Descripcion),
                         new JProperty("Imagen", Imagen),
                         new JProperty("IdCatalogo", IdCatalogo));

            return Datos;
        }
     


    }
}