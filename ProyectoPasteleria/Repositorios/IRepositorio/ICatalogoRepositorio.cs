using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPasteleria.Modelos;
using ProyectoPasteleria.Entidades;

namespace ProyectoPasteleria.Repositorios.IRepositorio
{
    interface ICatalogoRepositorio
    {
        Catalogo GetById(int CatalogoId);
        void Insert(Catalogo Catalogo);
        void Delete(int CatalogoId);
        void Update(Catalogo Catalogo);
    }
}
