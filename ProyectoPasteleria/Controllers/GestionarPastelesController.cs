using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProyectoPasteleria.Repositorio;
using ProyectoPasteleria.Models;

namespace ProyectoPasteleria.Controllers
{
    public class GestionarPastelesController : Controller
    {
        // GET: GestionarPasteles

        private IRepositorio<Pastel> _repositorio;

        public GestionarPastelesController()
        {

            _repositorio = new Repositorio<Pastel>();

        }
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Actualizar()
        {

            return View();

        }

        public ActionResult Registrar() {

            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Pastel pastel) {
            
            pastel.ID_CATALOGO = 1;
           

            _repositorio.Agregar(pastel);

            return View();
        }

        public ActionResult Eliminar(){

            return View();
        }

    }
}