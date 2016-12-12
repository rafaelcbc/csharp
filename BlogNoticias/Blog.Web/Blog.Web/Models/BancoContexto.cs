using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Web.Models
{
    public class BancoContexto : DbContext
    {
        public DbSet<Noticia> Noticias { get; set; }
    }
}