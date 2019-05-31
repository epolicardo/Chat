namespace Chat.Data.Entities
{
    public class Aulas
    {
        public int Id { get; set; }
        public Materias Materia { get; set; }
        public Profesores Profesor { get; set; }
    }
}