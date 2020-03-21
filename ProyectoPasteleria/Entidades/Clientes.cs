using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{

    public class Clientes
    {
        public int Id { get => Id; set => Id = value; }
        public String Direccion { get => Direccion; set => Direccion = value; }
        public String Ciudad { get => Ciudad; set => Ciudad = value; }
        public String Departamento { get => Departamento; set => Departamento = value; }
        public int Telefono { get => Telefono; set => Telefono = value; }

       // public string[] MediosEnvio { get => MediosEnvio; set => MediosEnvio.Append(value); }
       // public String[] MediosPago { get => MediosPago; set => MediosPago.Append(value); }



        //constructor de la clase cliente

        public Clientes(int id,  string direccion, string ciudad, string departamento, int telefono,  string[] mediosEnvio, string[] mediosPago)
        {
            Id = id;
    
            Direccion = direccion;
            Ciudad = ciudad;
            Departamento = departamento;
            Telefono = telefono;
    
        //    MediosEnvio = mediosEnvio;
          //  MediosPago = mediosPago;
        }

       
        //Genera un json con toda la informacion de cliente
        public JObject GetDatos()
        {
            JObject Datos = new JObject();

            Datos = new JObject(
                        new JProperty("Id", Id),
                     //   new JProperty("Nombre", Nombre),
                       // new JProperty("Apellido", Apellido),
                        new JProperty("Direccion", Direccion),
                        new JProperty("Ciudad", Ciudad),
                        new JProperty("Departamento", Departamento),
                        new JProperty("Telefono", Telefono),
                      //  new JProperty("Correo_Electronico", Correo_Electronico),
                      //  new JProperty("Contraseña", Contraseña),
                     //   new JProperty("MediosEnvio", MediosEnvio),
                      //  new JProperty("MediosPago", MediosPago));


          
            return Datos;
        }

        //añader un nuevo medio de envio

       
    }
    
}