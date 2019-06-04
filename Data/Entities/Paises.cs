using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Data.Entities
{
    public class Paises : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
