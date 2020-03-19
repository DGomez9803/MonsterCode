using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ProyectoPasteleria.Entidades
{
    public class Pastel
    {
        private int Id { get => Id; set => Id = value; }
        private String Nombre { get => Nombre; set => Nombre = value; }
        public double Peso { get => Peso; set => Peso = value; } 
        private String Categoria { get => Categoria; set => Categoria = value; }
        public double Precio { get => Precio; set => Precio = value; }
        private String Descripcion { get => Descripcion; set => Descripcion = value; }
        private Image Imagen { get => Imagen; set => Imagen = value; }
        private int IdCatalogo { get => IdCatalogo; set => IdCatalogo = value; }
        //constructor de la clase paatel
        public Pastel(int id, string nombre, double peso, string categoria, double precio, string descripcion, int idCatalogo)
        {
            Id = id;
            Nombre = nombre;
            Peso = peso;
            Categoria = categoria;
            Precio = precio;
            Descripcion = descripcion;
         
            IdCatalogo = idCatalogo;
        }

      


       
        
        //Genera un json con toda la informacion de pastel
        public JObject GetDatos()
        {
            JObject Datos = new JObject();

             Datos = new JObject(
                         new JProperty("Id", Id),
                         new JProperty("Nombre", Nombre),
                         new JProperty("Peso", Peso),
                         new JProperty("Categoria", Categoria),
                         new JProperty("Precio", Precio),
                         new JProperty("Descripcion", Descripcion),
                         new JProperty("Imagen", Imagen),
                         new JProperty("IdCatalogo", IdCatalogo));

            return Datos;
        }
     
        public void SetDescripcion(String descripcion) => Descripcion = descripcion;
        public Pastel GetPatel() => this;

        //para elimina el pastel
        public Boolean DestroyPastel(Pastel pastel) => true;
    }
}