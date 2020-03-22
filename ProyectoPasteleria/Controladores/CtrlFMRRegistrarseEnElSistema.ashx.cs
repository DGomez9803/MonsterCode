using ProyectoPasteleria.Repositorios;
using System.Web.Mvc;

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