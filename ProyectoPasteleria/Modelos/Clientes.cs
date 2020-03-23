using Newtonsoft.Json.Linq;
using System;

namespace ProyectoPasteleria.Modelos
{

    public class Clientes : Usuario
    {

        public String Direccion { get => Direccion; set => Direccion = value; }
        public String Ciudad { get => Ciudad; set => Ciudad = value; }
        public String Departamento { get => Departamento; set => Departamento = value; }
        public int Telefono { get => Telefono; set => Telefono = value; }




        //Genera un json con toda la informacion de cliente

        public JObject GetDatos()
        {
            JObject Datos = new JObject();

            Datos = new JObject(
                        // new JProperty("Id", Id),
                        //   new JProperty("Nombre", Nombre),
                        // new JProperty("Apellido", Apellido),
                        new JProperty("Direccion", Direccion),
                       new JProperty("Ciudad", Ciudad),
                        new JProperty("Departamento", Departamento),
                        new JProperty("Telefono", Telefono));
            //  new JProperty("Correo_Electronico", Correo_Electronico),
            //  new JProperty("Contraseña", Contraseña),
            //   new JProperty("MediosEnvio", MediosEnvio),
            //  new JProperty("MediosPago", MediosPago));



            return Datos;
        }



    }

}