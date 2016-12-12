using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkEscola.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkEscola.DataAccess.Map
{
    public class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            ToTable("Professor");
            HasKey(x => x.ProfessorId);
            Property(x => x.Nome).HasMaxLength(150).IsRequired();
        }
    }
}
