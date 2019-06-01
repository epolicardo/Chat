namespace Chat.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Mensajes : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Enviado")]
        public DateTime FechaEnviado { get; set; }
        [Display(Name = "Mensaje")]
        public string CuerpoMensaje { get; set; }
        public Usuarios Emisor { get; set; }
        public Salas Sala { get; set; }


    }
}
