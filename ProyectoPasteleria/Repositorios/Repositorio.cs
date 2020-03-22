using Fluent.Infrastructure.FluentModel;
using ProyectoPasteleria.Modelos;
using System.Data.Entity;

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