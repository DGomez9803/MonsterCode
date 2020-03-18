﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Controladoras
{
    /// <summary>
    /// Descripción breve de CtrlFRMGestionarPasteles
    /// </summary>
    public class CtrlFRMGestionarPasteles : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}