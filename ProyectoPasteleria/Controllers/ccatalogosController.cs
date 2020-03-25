using ProyectoPasteleria.Models;
using ProyectoPasteleria.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasteleria.Controllers
{
    public class ccatalogosController : Controller
    {
        IRepositorio<Catalogo> _repositorio;
        // GET: ccatalogos
        public ActionResult Index()
        {
            _repositorio = new Repositorio<Catalogo>();
            HashSet<Catalogo> catalogos = _repositorio.catalogos();
            List<Catalogo> lst = catalogos.ToList();

            return View(lst);
        }
    }
}