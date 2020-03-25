using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPasteleria.Repositorio;
using ProyectoPasteleria.Models;



namespace ProyectoPasteleria.Controllers
{
    public class AutenticarseController : Controller
    {

        private Repositorio<Usuario> _repositorio;

        public AutenticarseController()
        {
            _repositorio = new Repositorio<Usuario>();

        }

        public ActionResult Index()
        {
       

            return View();
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            Usuario usi=_repositorio.VerificaUsuario(usuario.CORREO_ELECTRONICO_USUARIO, usuario.CONTRASEÑA_USUARIO);
            
            if (usi==null)
            {

                ViewBag.Message = "Contraseña o Correo erroneos";
                return View();
            }
            else
            {
                if (_repositorio.VerificaAministrador(usi.ID_USUARIO)==null)
                {
                    Session["User"] = usuario;
                    Session["Admin"] = null;
                }
                else
                {
                    Session["User"] = null;
                    Session["Admin"] = usuario;

                }

                return RedirectToAction("Index", "Home");
            }
        }
        
        public ActionResult CerrarSeccion()
        {
            Session["User"] = null;
            Session["Admin"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
