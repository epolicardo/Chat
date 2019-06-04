namespace Chat.Data
{
    using Database.Data;
    using Database.Data.Entities;

    public class RepositorioPaises : RepositorioGenerico<Paises>, IRepositorioPaises
    {

        public RepositorioPaises(DataContext context) : base(context)
        {

        }
    }
}
