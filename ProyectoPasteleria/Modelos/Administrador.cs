using System;
using System.Net.Mail; // Acciones email's de .Net

namespace ProyectoPasteleria.Modelos
{
    public class Administrador : Usuario
    {

        public Administrador() { }
        public String Area { get => Area; set => Area = value; }


        //By: Toño
        // enviea correo al administrador notificando que se realizo un pedido exitoso
        public Boolean NotificarPedidoExitosoAdministrador()
        {
            Boolean flag = false;


            string Emailsistema = "gomezbeltran.manuel10@gmail.com";
            string EmailConstraseña = "9806285178336";

            // Variable tipo mensaje de correo que tiene correo origen, correo destino, asunto del correo y mensaje 
            MailMessage sistemaMailMessage = new MailMessage(Emailsistema, Emailsistema, "Nuevo Pedido", "datos del pedido");

            // SMTP (protocolo de trasnferencia de correo) variable que trasnportara el correo
            SmtpClient origenSmtpclient = new SmtpClient("smtp.gmail.com");
            // correo seguro
            origenSmtpclient.EnableSsl = true;
            // no usar por defecto las credenciales 
            origenSmtpclient.UseDefaultCredentials = false;
            // por si no funciona
            // origenSmtpclient.Host = "stmp.gmail.com";
            // puerto que usa el protocolo SMTP
            origenSmtpclient.Port = 587;
            // credenciales dentro del objeto System.Net.NetworkCredential con email y contraseña 
            origenSmtpclient.Credentials = new System.Net.NetworkCredential(Emailsistema, EmailConstraseña);
            // enviar el mensaje con el SMTP configurado
            origenSmtpclient.Send(sistemaMailMessage);

            //Eliminar todo del protocolo SMTP
            origenSmtpclient.Dispose();

            
            return flag = true;
        }

         public static void Main()
        {
            Administrador Admin = new Administrador();
            Admin.NotificarPedidoExitosoAdministrador();
        }

    }
  
}