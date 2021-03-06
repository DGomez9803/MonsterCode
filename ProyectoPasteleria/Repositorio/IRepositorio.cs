﻿using ProyectoPasteleria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPasteleria.Repositorio
{
    interface IRepositorio<T>
    {

        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Actualizar(T entidad);
        Catalogo calogoPorId(int id);
        HashSet<Pastel> getPasteles(int idc);
        HashSet<Catalogo> catalogos();
    }
}
