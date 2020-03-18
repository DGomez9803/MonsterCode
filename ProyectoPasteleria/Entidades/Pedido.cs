using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Entidades
{
    public class Pedido
    {
        private int IdCliente;
        private Dictionary<Pastel, int> Pasteles = new Dictionary<Pastel, int>();
        private Double Total;
        private DateTime Fecha;
        private String MedioEnvio;
        private String MedioPago;

        public Pedido(int idCliente,Dictionary<Pastel, int> pasteles, double total, DateTime fecha, string medioEnvio)
        {
             IdCliente= idCliente;
             Pasteles = pasteles;
            Total = total;
            Fecha = fecha;
            MedioEnvio = medioEnvio;
        }
        //retorna la cantidad total de pasteles que hay en el pedido
        public int GetCantidad()
        {
            int cantidad=0;
            foreach (KeyValuePair<Pastel, int> pastel in Pasteles)
            {
                cantidad += pastel.Value;
            }
            return cantidad;
        }
        //retorna el valor total de el pedido
        public double GetTotal()
        {
            double total = 0;
            foreach (KeyValuePair<Pastel, int> pastel in Pasteles)
            {
                total += (pastel.Value)* pastel.Key.GetPrecio();
            }
            return total;
        }
        //retorna todos los pasteles en el pedido
        public ArrayList GetPateles()
        {
            ArrayList pasteles = new ArrayList();
            foreach (KeyValuePair<Pastel, int> pastel in Pasteles)
            {
                pasteles.Add(pastel.Key);
            }
            return pasteles;
        }
        public void SetMedioEnvio(String medioEnvio)
        {
            MedioEnvio = medioEnvio;
        }
        public void SetMedioPago(String medioPago)
        {
            MedioPago = medioPago;
        }
        //recibe el  pastelque quiere elimina de la lista de pedido y lo elimina de pedido
        public void EliminarPastel(Pastel pastel)
        {
            Pasteles.Remove(pastel);
        }
        public int GetIdCliente()
        {
            return IdCliente;
        }
    }
}