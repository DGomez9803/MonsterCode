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
        private int Id;
        private String Nombre;
        private Double Peso;
        private String Categoria;
        private Double Precio;
        private String Descripcion;
        private Image Imagen;

        //constructor de la clase paatel

        public Pastel(int id, string nombre, double peso, string categoria, double precio, string descripcion, Image imagen)
        {
            Id = id;
            Nombre = nombre;
            Peso = peso;
            Categoria = categoria;
            Precio = precio;
            Descripcion = descripcion;
            Imagen = imagen;
        }
        public int GetId()
        {
            return Id;
        }
        public Double GetPrecio()
        {
            return Precio;
        }
        public String GetNombre()
        {
            return Nombre;

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
                         new JProperty("Imagen", Imagen));
           
            return Datos;
        }
        public void SetNombre(String nombre)
        {
            Nombre = nombre;

        }
        public void SetPeso( double peso)
        {
         
            Peso = peso;
        }
        public void SetPrecio(double precio)
        {

            Precio = precio;
        }
        public void SetDescripcion(String  descripcion)
        {

            Descripcion = descripcion;
        }
        public Pastel GetPatel()
        {
            return this;
        }
        //para elimina el pastel
        public Boolean  DestroyPastel(Pastel pastel)
        {
            return true;
                }
    }
}