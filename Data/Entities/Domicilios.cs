namespace Chat.Data.Entities
{
    public class Domicilios
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Nro { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public Barrios Barrio { get; set; }
        public Localidades Localidad { get; set; }
    }
}
