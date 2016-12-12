using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEscola.Domain.Entities
{
    public class Curso
    {
        public Curso()
        {
            ProfessorLista = new List<Professor>();
            Ativo = true;
        }
        public int CursoId { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Professor> ProfessorLista { get; set; }
        public override string ToString()
        {
            return Descricao;
        }
    }
}
