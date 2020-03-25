using ProyectoPasteleria.Models;
using ProyectoPasteleria.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasteleria.Controllers
{
    public class gcatalogosController : Controller
    {
        IRepositorio<Catalogo> _repositorio;
        // GET: gcatalogos
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Catalogo cat) {
            _repositorio = new Repositorio<Catalogo>();            
            Catalogo nuevo = new Catalogo();
            nuevo.NOMBRE_CATALOGO = cat.NOMBRE_CATALOGO;
            _repositorio.Agregar(nuevo);
            return RedirectToAction("/");           
                               
        }
        
    }
}