using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Administrador
    {
        private String Nombre;
        private String Apellido;
        private String Direccion;
        private String Ciudad;
        private String Departamento;
        private int Telefono;
        private String Correo_Electronico;
        private String Contraseña;

        public Administrador(string nombre, string apellido, string direccion, string ciudad, string departamento, int telefono, string correo_Electronico, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Ciudad = ciudad;
            Departamento = departamento;
            Telefono = telefono;
            Correo_Electronico = correo_Electronico;
            Contraseña = contraseña;
        }
    }
}