namespace Chat.Data.Entities
{
    using System;

    public class Mensajes
    {
        public int Id { get; set; }
        public DateTime FechaEnviado { get; set; }
        public string CuerpoMensaje { get; set; }
        public Usuarios Emisor { get; set; }
        public Salas Sala { get; set; }

        public Mensajes()
        {
            
        }

    }
}
