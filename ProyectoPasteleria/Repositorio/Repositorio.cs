using Fluent.Infrastructure.FluentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPasteleria.Models;



namespace ProyectoPasteleria.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidad
    {
        public void Actualizar(T entidad)
        {

            using (var db = new DataBase.DbContextLocal())
            {
                db.Entry(entidad).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void Agregar(T entidad)
        {
            using (var db = new DataBase.DbContextLocal())
            {

                db.Entry(entidad).State = System.Data.Entity.EntityState.Added;

                db.SaveChanges();
            }
        }

        public void Eliminar(T entidad)
        {

            using (var db = new DataBase.DbContextLocal())
            {

                db.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }



        public HashSet<Pedido> getPedidos(int idc)
        {
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Pedido>().Where(p => p.ID_CLIENTE == idc).ToHashSet<Pedido>();
            }
        }
        public HashSet<Factura> getFactura(int id)
        {
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Factura>().Where(f => f.ID_PEDIDO == id).ToHashSet<Factura>();
            }
        }
        public HashSet<Pastel> getPastelPedido(int idc)
        {            
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Pastel>().Where(q => q.ID_PASTEL == idc).ToHashSet<Pastel>();
            }            
        }
        public Usuario getInfoUsuario(int id) {
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Usuario>().FirstOrDefault(u => u.ID_USUARIO == id);
            }
        }
    }
}