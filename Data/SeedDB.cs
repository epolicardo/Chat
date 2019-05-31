namespace Chat.Data
{
    using Chat.Data.Entities;
    using Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDB
    {
        private readonly DataContext context;
        private Random random;

        public SeedDB(DataContext context)
        {
            this.context = context;
            this.random = new Random();

        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
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

        }
        private void AddLocalidades(string Localidad)
        {
            this.context.Localidades.Add(new Localidades
            {
                Localidad = Localidad

            });
        }
    }
}
