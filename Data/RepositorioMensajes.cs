namespace Chat.Data
{
    using Database.Data;
    using Database.Data.Entities;

    public class RepositorioMensajes : RepositorioGenerico<Mensajes>, IRepositorioMensajes
    {
        public RepositorioMensajes(DataContext context) : base(context)
        {

        }
    }
}
