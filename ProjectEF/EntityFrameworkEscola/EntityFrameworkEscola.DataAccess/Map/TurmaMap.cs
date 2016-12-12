using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkEscola.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkEscola.DataAccess.Map
{
    public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            ToTable("Turma");
            HasKey(x => x.TurmaId);

            /*Na entidade Turma, a propriedade do tipo Curso é obrigatória*/
            HasRequired(x => x.Curso)
               .WithMany() //Curso pode ter muitas turmas
               .Map(m => m.MapKey("CursoId"));//a chave estrangeira em Turma é CursoId

            /*Novamente, em Turma a propriedade do tipo Professor é requerida*/
            HasRequired(x => x.Professor)
               .WithMany(x => x.TurmaLista) //a classe Professor pode ter uma lista de Turma
               .Map(m => m.MapKey("ProfessorId"));//a chave estrangeira é ProfessorId
        }
    }
}
