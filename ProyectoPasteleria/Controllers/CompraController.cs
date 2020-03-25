//// -----------------------------------------------------------------------
//// <copyright file="CompraController.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPasteleria.Models;
using ProyectoPasteleria.Repositorio;

namespace ProyectoPasteleria.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        IRepositorio<Pedido> _repositorio;                           
        public ActionResult Index()
        {
            _repositorio = new Repositorio<Pedido>();
            Usuario usuario = (Usuario)HttpContext.Session["Usuario"];
            HashSet<Usuario> usuarios = new HashSet<Usuario>();
            usuarios.Add(usuario);
           /* dynamic mymodel = new ExpandoObject();
            mymodel.pedidos = _repositorio.getPedidos(usuario.ID_USUARIO).ToList();
            mymodel.usuario = usuario;*/
            return View(_repositorio.getPedidos(usuario.ID_USUARIO).ToList());
        }
    }
}