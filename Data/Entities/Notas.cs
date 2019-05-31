namespace Chat.Data.Entities
{

    using System;

    public class Notas
    {
        public int Id { get; set; }
        public Aulas Aula { get; set; }
        public decimal Calificacion { get; set; }
        public Alumnos Alumno { get; set; }
        public DateTime Fecha { get; set; }
    }
}
