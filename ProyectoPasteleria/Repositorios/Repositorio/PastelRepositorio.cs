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
    

    public Pastel GetById(int id)
    {
        return Query(id).FirstOrDefault();
    }

        
       
      
        public void Insert(Pastel Pastel)
        {
             Insert<int>(Pastel);
        }
        
        public void Delete(int id)
        {
             Delete(id);
        }
     

        public void  Update(Pastel Pastel)
        {
             Update(Pastel);
        }
       
    }

}