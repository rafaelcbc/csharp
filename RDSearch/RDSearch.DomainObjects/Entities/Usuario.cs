﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDSearch.DomainObjects.Entities
{
    class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
