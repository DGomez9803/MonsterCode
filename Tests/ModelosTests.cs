using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPasteleria.Modelos;
using System;
     

namespace Tests
{
    [TestClass]
    public class ModelosTests
    {
        [TestMethod]
        public void TestEnviaCorreoAdministrador()
        { 
            Administrador admin = new Administrador();
            Boolean flag = admin.NotificarPedidoExitosoAdministrador();
            Assert.IsTrue(flag);
        }
    }
}
