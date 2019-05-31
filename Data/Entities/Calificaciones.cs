
namespace Chat.Data.Entities
{
    using System;
    public class Calificaciones
    {
        public int Id { get; set; }
        public DateTime FechaCalificacion { get; set; }
        public Alumnos Alumno { get; set; }
        public float Calificacion { get; set; }
    }
}
