using Chat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Data
{
    public class RepositorioMensajes : RepositorioGenerico<Mensajes>, IRepositorioMensajes
    {
        public RepositorioMensajes(DataContext context) : base(context)
        {

        }
    }
}
