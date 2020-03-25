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
        public Catalogo calogoPorId(int id) {
            using (var db = new DataBase.DbContextLocal()) {
                return db.Set<Catalogo>().FirstOrDefault(x => x.ID_CATALOGO == id);
            }
        }
        public HashSet<Catalogo> catalogos() {

            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Catalogo>().ToHashSet<Catalogo>();
            }
        }
        public HashSet<Pastel> getPasteles(int idc) {
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Pastel>().Where(x => x.ID_CATALOGO == idc).ToHashSet<Pastel>();
            }
        }

        public HashSet<Pedido> getPedidos(int id) {
            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Pedido>().Where(p => p.ID_CLIENTE == id).ToHashSet<Pedido>();
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
    }
}