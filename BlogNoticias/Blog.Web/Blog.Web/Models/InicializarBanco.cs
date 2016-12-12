using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Web.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            new List<Noticia> {
                new Noticia {
                    DataDaPublicacao = DateTime.Now,
                    Assunto = "Globalização",
                    Descricao = "A Globalização..."
                }
            }.ForEach(n => context.Noticias.Add(n));


            base.Seed(context);
        }
    }
}