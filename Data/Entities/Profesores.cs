namespace Chat.Data.Entities
{
    using Chat.Data.Entities;
    using System.Collections.Generic;

    public class Profesores
	{
        public int Id { get; set; }
        public Usuarios Usuarios { get; set; }
        public List<Aulas> Aulas { get; set; }
	}
}
