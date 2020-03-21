using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPasteleria;

namespace ProyectoPasteleria.Repositorios
{
    public interface IRepositorio <T>
    {
  
        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Actualizar(T entidad);
    }
}
