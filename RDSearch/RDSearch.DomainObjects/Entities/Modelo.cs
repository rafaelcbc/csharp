using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDSearch.DomainObjects.Entities
{
    class Modelo
    {
        public int TipoId { get; set; }
        public string Nome { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
