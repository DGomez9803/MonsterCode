using ProyectoPasteleria.Models;
using ProyectoPasteleria.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasteleria.Controllers
{
    public class ComprarPastelController : Controller
    {

        private List<Pastel> Pasteles;
        private List<Pedido> Pedidos;
        private IRepositorio<Pedido> _repositorioPedido;
        private IRepositorio<Usuario> _repositorioUsuario;
        private IRepositorio<Pastel> _repositorioPastel;

        public ComprarPastelController()
        {
            _repositorioPedido = new Repositorio<Pedido>();
            _repositorioUsuario = new Repositorio<Usuario>();
            _repositorioPastel = new Repositorio<Pastel>();
        }

        public ActionResult Index()
        {
            Usuario usuario = _repositorioUsuario.ObtenerPorIdUsuario(20);

            ViewData["NameU"] = "" + usuario.NOMBRE_USUARIO;

            //Usuario usuario = _repositorio.ObtenerPorId(15);
            //Administrador admin = new Administrador();
            //admin.NotificarPedidoExitosoAdministrador(usuario.CORREO_ELECTRONICO_USUARIO);

            return View();
        }

        public ActionResult MostrarPedido()
        {
            Usuario usuario = _repositorioUsuario.ObtenerPorIdUsuario(20);

            Pedidos = new List<Pedido>();
            Pasteles = new List<Pastel>();
            double total = 0;
            Pedido pedido = _repositorioPedido.ObtenerPorIdUsuarioPedido(20);
            while ( pedido!= null)
            {
                Pedidos.Add(pedido);
                Pastel pastel = _repositorioPastel.ObtenerPorIdPastel(pedido.ID_PASTEL);
                Pasteles.Add(pastel);
                total = total + (double)pedido.TOTAL;
                _repositorioPedido.Eliminar(pedido);
                pedido = _repositorioPedido.ObtenerPorIdUsuarioPedido(20);
            }

            ViewData["NameU"] = "" + usuario.NOMBRE_USUARIO;
            ViewData["Total"] = "Total a pagar: " +total;
            ViewData["NombrePastel0"] = "" + Pasteles.FirstOrDefault().NOMBRE_PASTEL;
            ViewData["PesoPastel0"] = "" + Pasteles.FirstOrDefault().PESO_PASTEL + " gr";
            ViewData["PrecioPastel0"] = "" + Pasteles.FirstOrDefault().PRECIO_PASTEL + "COP";
            ViewData["Descripcion0"] = "" + Pasteles.FirstOrDefault().DESCRIPCION_PASTEL;
            ViewData["Cantidad0"] = "" + Pedidos.FirstOrDefault().TOTAL;
            Pasteles.RemoveAt(0);
            Pedidos.RemoveAt(0);

            if (Pasteles.Count != 0 ) {
                ViewData["NombrePastel1"] = "" + Pasteles.FirstOrDefault().NOMBRE_PASTEL;
                ViewData["PesoPastel1"] = "" + Pasteles.FirstOrDefault().PESO_PASTEL + " gr";
                ViewData["PrecioPastel"] = "" + Pasteles.FirstOrDefault().PRECIO_PASTEL + "COP";
                ViewData["Descripcion1"] = "" + Pasteles.FirstOrDefault().DESCRIPCION_PASTEL;
                ViewData["Cantidad1"] = "" + Pedidos.FirstOrDefault().TOTAL;
                Pasteles.RemoveAt(0);
                Pedidos.RemoveAt(0);
            }
            if (Pasteles.Count != 0) {
                ViewData["NombrePastel2"] = "" + Pasteles.FirstOrDefault().NOMBRE_PASTEL;
                ViewData["PesoPastel2"] = "" + Pasteles.FirstOrDefault().PESO_PASTEL + " gr";
                ViewData["PrecioPastel2"] = "" + Pasteles.FirstOrDefault().PRECIO_PASTEL + "COP";
                ViewData["Descripcion2"] = "" + Pasteles.FirstOrDefault().DESCRIPCION_PASTEL;
                ViewData["Cantidad2"] = "" + Pedidos.FirstOrDefault().TOTAL;
                Pasteles.RemoveAt(0);
                Pedidos.RemoveAt(0);
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}