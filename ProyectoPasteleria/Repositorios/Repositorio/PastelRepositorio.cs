using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProyectoPasteleria.Entidades;
using ProyectoPasteleria.Repositorios.IRepositorio;
using RepoDb;

namespace ProyectoPasteleria.Repositorios.Repositorio
{
    public class PastelRepositorio : BaseRepository<Pastel, SqlConnection>,IPastelRepositorio
    {
 
        public DbSet<Pastel> Categories { get; set; }


        public PastelRepositorio()
        : base(@"Server=.;Database=Pastel;Integrated Security=SSPI;")
        { }
    

    public Pastel GetById(long id)
    {
        return Query(id).FirstOrDefault();
    }

        
       
      
        public long Insert(Pastel Pastel)
        {
            return Insert<long>(Pastel);
        }
        
        public int Delete(long id)
        {
            return Delete(id);
        }
     

        public int Update(Pastel Pastel)
        {
            return Update(Pastel);
        }
       
    }

}