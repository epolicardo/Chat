using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Data.Entities;

namespace Chat.Data
{
    public class MockRepositorio : IRepositorio
    {
        void IRepositorio.AddMensajes(Mensajes mensaje)
        {
            throw new NotImplementedException();
        }

        Mensajes IRepositorio.GetMensaje(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Mensajes> IRepositorio.GetMensajes()
        {
            var mensajes = new List<Mensajes>();
            mensajes.Add(new Mensajes { CuerpoMensaje = "Hola Amigos", FechaEnviado = DateTime.Now});
            mensajes.Add(new Mensajes { CuerpoMensaje = "Hola!", FechaEnviado = DateTime.Now});
            mensajes.Add(new Mensajes { CuerpoMensaje = "Como va?", FechaEnviado = DateTime.Now});
            return mensajes;
        }

        bool IRepositorio.MensajeExists(int id)
        {
            throw new NotImplementedException();
        }

        void IRepositorio.RemoveMensajes(Mensajes mensaje)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepositorio.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        void IRepositorio.UpdateMensajes(Mensajes mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
