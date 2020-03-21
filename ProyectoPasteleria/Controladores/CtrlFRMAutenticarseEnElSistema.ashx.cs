using ProyectoPasteleria.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasteleria.Controladoras
{
    /// <summary>
    /// Descripción breve de Autetica
    /// </summary>
    public class CtrlFRMAutenticarseEnElSistema : Controller
    {

        private IRepositorio<Usuario> _repositorio;
        public CtrlFRMAutenticarseEnElSistema (IRepositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;
        }
    }
}