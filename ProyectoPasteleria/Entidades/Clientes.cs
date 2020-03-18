using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{

    public class Clientes
    {
        private int Id;
        private String Nombre;
        private String Apellido;
        private String Direccion;
        private String Ciudad;
        private String Departamento;
        private int Telefono;
        private String Correo_Electronico;
        private String Contraseña;
        private String[] MediosEnvio;
        private String[] MediosPago;


        //constructor de la clase cliente

        public Clientes(int id, string nombre, string apellido, string direccion, string ciudad, string departamento, int telefono, string correo_Electronico, string contraseña, string[] mediosEnvio, string[] mediosPago)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Ciudad = ciudad;
            Departamento = departamento;
            Telefono = telefono;
            Correo_Electronico = correo_Electronico;
            Contraseña = contraseña;
            MediosEnvio = mediosEnvio;
            MediosPago = mediosPago;
        }

        public String GetContraseña()
        {
            return Contraseña;
        }
        public String GetCorreo_Electronico()
        {
            return Correo_Electronico;

        }

        //Genera un json con toda la informacion de cliente
        public JObject GetDatos()
        {
            JObject Datos = new JObject();

            Datos = new JObject(
                        new JProperty("Id", Id),
                        new JProperty("Nombre", Nombre),
                        new JProperty("Apellido", Apellido),
                        new JProperty("Direccion", Direccion),
                        new JProperty("Ciudad", Ciudad),
                        new JProperty("Departamento", Departamento),
                        new JProperty("Telefono", Telefono),
                        new JProperty("Correo_Electronico", Correo_Electronico),
                        new JProperty("Contraseña", Contraseña),
                        new JProperty("MediosEnvio", MediosEnvio),
                        new JProperty("MediosPago", MediosPago));


          
            return Datos;
        }

        //añader un nuevo medio de envio

        public void AddMediosEnvio(String medio)
        {
            MediosEnvio.Append(medio);
        }
        public String[] GetMediosEnvio()
        {
            return MediosEnvio;
        }
        //añader un nuevo metodo de pago
        public void AddMediosPago(String medio)
        {
            MediosPago.Append(medio);
        }
        public String[] GetMediosPago()
        {
            return MediosPago;
        }
    }
    
}