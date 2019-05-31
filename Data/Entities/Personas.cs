using System;
using System.ComponentModel.DataAnnotations;

namespace Chat.Data.Entities
{
    public class Personas
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        //Ej. 1 - DNI / 2 - Pasaporte / 3 - LE
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public int Genero { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoFijo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
    }
}