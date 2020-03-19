using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProyectoPasteleria.Repositorio
{
    public class GenericRepository<T> 
     where T : class
    {

        DataContext db;

        public GenericRepository(DataContext db)
        {
            this.db = db;
        }

        public IQueryable<T> Query
        {
            get { return db.GetTable<T>(); }
        }

        public List<T> FetchAll()
        {
            return Query.ToList();
        }

        public void Add(T entity)
        {
            db.GetTable<T>().InsertOnSubmit(entity);
        }

        public void Delete(T entity)
        {
            db.GetTable<T>().DeleteOnSubmit(entity);
        }

        public void Save()
        {
            db.SubmitChanges();
        }
    }
}