using ProyectoPasteleria.Repositorios;
using System.Web.Mvc;

namespace ProyectoPasteleria.Controladoras
{
    /// <summary>
    /// Descripción breve de Autetica
    /// </summary>
    public class CtrlFRMAutenticarseEnElSistema : Controller
    {

        private IRepositorio<Usuario> _repositorio;
        public CtrlFRMAutenticarseEnElSistema(IRepositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;
        }
    }
}