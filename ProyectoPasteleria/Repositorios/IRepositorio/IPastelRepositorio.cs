using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPasteleria.Modelos;
using ProyectoPasteleria.Entidades;

namespace ProyectoPasteleria.Repositorios.IRepositorio
{
    interface IPastelRepositorio : IDisposable
    {
        IEnumerable<Pastel> GetStudents();
        Pastel GePatelByID(int PastelId);
        void Inser(Pastel Pastel);
        void Delete(int PastelId);
        void Update(Pastel Pastel);
    }
}
