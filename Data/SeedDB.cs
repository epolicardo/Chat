namespace Chat.Data
{
    using Chat.Data.Entities;
    using Chat.Helpers;
    using Microsoft.AspNetCore.Identity;
    using Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDB
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        
        private Random random;

        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();

        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();


            var usuario = await this.userHelper.GetUsuarioByEmailAsync("emilianopolicardo@gmail.com");
            if (usuario == null)
            {
                var persona = new Personas
                {
                    Nombre = "Emiliano",
                    Apellido = "Policardo"
                };
                usuario = new Usuarios
                {
                    Persona = persona,
                    PhoneNumber = "3513416192",
                    UserName = "emilianopolicardo@gmail.com",
                    Email = "emilianopolicardo@gmail.com"
                };
                var result = await this.userHelper.AddUserAsync(usuario, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }

            }

            if (!this.context.Localidades.Any())
            {
                this.AddLocalidades("Córdoba");
                this.AddLocalidades("Rio Segundo");
                this.AddLocalidades("Rio Ceballos");
                this.AddLocalidades("Unquillo");
                this.AddLocalidades("Villa Allende");
                this.AddLocalidades("Agua de Oro");
                this.AddLocalidades("Córdoba");
                this.AddLocalidades("Rosario");
                this.AddLocalidades("Buenos Aires");
                await this.context.SaveChangesAsync();
            }

            if (!this.context.Mensajes.Any())
            {
                this.AddMensaje("Hola a todos desde el Seed", usuario);
                
                await this.context.SaveChangesAsync();
            }
        }
        private void AddLocalidades(string Localidad)
        {
            this.context.Localidades.Add(new Localidades
            {
                Localidad = Localidad

            });
        }
        private void AddMensaje(string mensaje, Usuarios usuario)
        {
            this.context.Mensajes.Add(new Mensajes
            {
                FechaEnviado = DateTime.Now,
                CuerpoMensaje = mensaje,
                Emisor = usuario
            });
        }
    }
}
