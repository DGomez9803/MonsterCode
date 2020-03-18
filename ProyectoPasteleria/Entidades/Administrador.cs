using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Administrador
    {
        private int Id;
        private String Nombre;
        private String Area;
        private String Correo_Electronico;
        private String Contraseña;

        //constructor de la clase administrador
        public Administrador(int id, string nombre, string area, string correo_Electronico, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Area = area;
            Correo_Electronico = correo_Electronico;
            Contraseña = contraseña;
        }
        public int GetId()
        {
            return Id;
        }
        public String GetNombre()
        {
            return Nombre;

        }
        public String GetArea()
        {
            return Area;

        }

        //Metodo que usa el administrado para notifica perdido exitoso
        public void NotificarPedidoExitoso()
        {

        }
    }
}