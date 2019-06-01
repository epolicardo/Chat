namespace Chat.Data
{
    using Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepositorio
    {
        void AddMensajes(Mensajes mensaje);
        Mensajes GetMensaje(int id);
        IEnumerable<Mensajes> GetMensajes();
        bool MensajeExists(int id);
        void RemoveMensajes(Mensajes mensaje);
        Task<bool> SaveAllAsync();
        void UpdateMensajes(Mensajes mensaje);
    }
}