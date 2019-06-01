namespace Chat.Data
{
    using Chat.Data.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Mensajes> GetMensajes()
        {
            return this.context.Mensajes.OrderBy(m => m.FechaEnviado);
        }

        public Mensajes GetMensaje(int id)
        {
            return this.context.Mensajes.Find(id);
        }
        public void AddMensajes(Mensajes mensaje)
        {
            this.context.Mensajes.Add(mensaje);
        }

        public void UpdateMensajes(Mensajes mensaje)
        {
            this.context.Mensajes.Update(mensaje);
        }
        public void RemoveMensajes(Mensajes mensaje)
        {
            this.context.Mensajes.Remove(mensaje);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool MensajeExists(int id)
        {
            return this.context.Mensajes.Any(m => m.Id == id);
        }



    }
}
