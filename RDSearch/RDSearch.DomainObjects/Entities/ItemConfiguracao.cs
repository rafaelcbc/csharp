using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDSearch.DomainObjects.Entities
{
    class ItemConfiguracao
    {
        public int ItemConfiguracaoId { get; set; }
        public int Patrimonio { get; set; }
        public string Serie { get; set; }

        public int TipoId { get; set; }
        public virtual Tipo Tipo { get; set; }

        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

        public int SalaId { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
