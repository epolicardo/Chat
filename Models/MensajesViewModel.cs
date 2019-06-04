using Chat.Data.Entities;
namespace Chat.Models
{

    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class MensajesViewModel : Mensajes
    {
        [Display(Name = "Adjunto")]
        public IFormFile ImageFile { get; set; }
    }
}
