namespace Chat.Data
{

    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : IdentityDbContext<Usuarios>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Personas> Personas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }
        public DbSet<Archivos> Archivos { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<CursosAlumnos> CursosAlumnos { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }
        public DbSet<Barrios> Barrios { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Domicilios> Domicilios { get; set; }
        public DbSet<Paises> Paises { get; set; }



    }
}
