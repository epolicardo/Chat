namespace Chat.Data
{
    using Chat.Data.Entities;

    public class RepositorioPaises : RepositorioGenerico<Paises>, IRepositorioPaises
    {

        public RepositorioPaises(DataContext context) : base(context)
        {

        }
    }
}
