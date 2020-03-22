using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ProyectoPasteleria.Repositorios;

using System.Web.Mvc;

namespace ProyectoPasteleria.Controladores
{
    /// <summary>
    /// Descripción breve de CtrlFRMAutenticarseEnElSistema
    /// </summary>
    public class CtrlFRMAutenticarseEnElSistema : Controller
    {



        private IRepositorio<Usuario> _repositorio;
        public CtrlFRMAutenticarseEnElSistema(IRepositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;

            var usuario = new Usuario()
            {
                NOMBRE_USUARIO = "Jun",
                APELLIDO_USUARIO = "Perez",
                CORREO_ELECTRONICO_USUARIO = "didie@gmail.com",
                CONTRASEÑA_USUARIO = "1234"
            };
            _repositorio.Agregar(usuario);
        }

        public void Index()
        {
            var usuario = new Usuario()
            {
                NOMBRE_USUARIO = "Junw",
                APELLIDO_USUARIO = "Perez",
                CORREO_ELECTRONICO_USUARIO = "didie@gmail.com",
                CONTRASEÑA_USUARIO = "1234"
            };
            _repositorio.Agregar(usuario);

        }
    }
}