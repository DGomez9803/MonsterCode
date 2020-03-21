using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPasteleria.Controladoras
{
    /// <summary>
    /// Descripción breve de CtrlFMRRegistrarseEnElSistema
    /// </summary>
    public class CtrlFMRRegistrarseEnElSistema : IHttpHandler
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