using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DocumentFormat.OpenXml.Office2010.Excel;
using Fluent.Infrastructure.FluentModel;
using Nest;
using ProyectoPasteleria.Modelos;
using ProyectoPasteleria.Repositorios;
using RepoDb;

namespace ProyectoPasteleria.Repositorios.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidad, new()
    {
        public void Actualizar(T entidad)
        {
            
            using (DbContext db = new ApplicationDbContext())
            {
                db.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Agregar(T entidad)
        {

            using (DbContext db = new ApplicationDbContext())
            {
                db.Entry(entidad).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }
         
        public void Eliminar(T entidad)
        {

            using (DbContext db = new ApplicationDbContext())
            {
                
                db.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}