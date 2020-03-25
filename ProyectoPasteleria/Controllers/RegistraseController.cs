using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPasteleria.Repositorio;
using ProyectoPasteleria.Models;


namespace ProyectoPasteleria.Controllers
{
    public class RegistraseController : Controller
    {

        private Repositorio<Usuario> _repositorio;

        public RegistraseController()
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
            if(usuario.VerificaDatosCliente())
            {
                _repositorio.Agregar(usuario);
                Session["User"]=usuario;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Falta campos por llenar";
                return View();
                

            }



        }

       
    }
}