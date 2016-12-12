using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDSearch.DomainObjects.Entities
{
    class RegistroItem
    {
        public int RegistroItemId { get; set; }
        public DateTime DataHora { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int ItemConfiguracaoId { get; set; }
        public virtual ItemConfiguracao ItemConfiguracao { get; set; }
    }
}
