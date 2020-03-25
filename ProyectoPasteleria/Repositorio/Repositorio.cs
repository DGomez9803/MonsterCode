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
        public Usuario ObtenerUsuarioPorId(int id)
        {

            using (var db = new DataBase.DbContextLocal())
            {
            
                return db.Set<Usuario>().FirstOrDefault(x => x.ID_USUARIO == id);


            }
        }
        //Recibe el correo y la contraseña y verifica si esta registrado en el sistema y retorna ese usuario
        public Usuario VerificaUsuario(String Correo,String contraseña)
        {

            using (var db = new DataBase.DbContextLocal())
            {

                return db.Set<Usuario>().FirstOrDefault(x => x.CORREO_ELECTRONICO_USUARIO == Correo && x.CONTRASEÑA_USUARIO == contraseña);


            }
        }

        public Administrador VerificaAministrador(int id)
        {

            using (var db = new DataBase.DbContextLocal())
            {

                return db.Set<Administrador>().FirstOrDefault(x => x.ID_ADMINISTRADOR == id );


            }
        }
        public HashSet<Catalogo> catalogos()
        {

            using (var db = new DataBase.DbContextLocal())
            {
                return db.Set<Catalogo>().ToHashSet<Catalogo>();
            }
        }
    }
}