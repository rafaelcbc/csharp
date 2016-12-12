using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDSearch.DomainObjects.Entities
{
    class Tipo
    {
        public int TipoId { get; set; }
        public string Nome { get; set; }

        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
