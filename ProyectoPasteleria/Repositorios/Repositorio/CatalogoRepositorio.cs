using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProyectoPasteleria.Entidades;
using ProyectoPasteleria.Repositorios.IRepositorio;
using RepoDb;

namespace ProyectoPasteleria.Repositorios.Repositorio
{
    public class CatalogoRepositorio : BaseRepository<Catalogo, SqlConnection>, ICatalogoRepositorio
    {

        public DbSet<Catalogo> Catalogo { get; set; }


        public CatalogoRepositorio()
        : base(@"Server=.;Database=Catalogo;Integrated Security=SSPI;")
        { }


        public Catalogo GetById(int id)
        {
            return Query(id).FirstOrDefault();
        }




        public void Insert(Catalogo Catalogo)
        {
            Insert<int>(Catalogo);
        }

        public void Delete(int id)
        {
            Delete(id);
        }


        public void Update(Catalogo Catalogo)
        {
            Update(Catalogo);
        }

    }
}
}