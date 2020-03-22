using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPasteleria.Repositorios;
using ProyectoPasteleria.Modelos;

namespace ProyectoPasteleria.Controladoras
{
    /// <summary>
    /// Descripción breve de CtrlFMRRegistrarseEnElSistema
    /// </summary>
    public class CtrlFMRRegistrarseEnElSistema : Controller
    {
        private IRepositorio<Usuario> _repositorio;

        public CtrlFMRRegistrarseEnElSistema(IRepositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;
        }




    }
}