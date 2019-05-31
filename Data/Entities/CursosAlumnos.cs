namespace Chat.Data.Entities
{
    //tabla para relacionar aulas y alumnos (muchos a muchos)
    public class CursosAlumnos
    {
        public int Id { get; set; }
        public Alumnos AlumnoId { get; set; }
        public Aulas CursoId { get; set; }
    }
}
