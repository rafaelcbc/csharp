using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Blog.Web.Models
{
    public class Noticia
    {
        [Key]
        public int IDNoticias { get; set; }

        [Display(Name = "Data da Publicação")]
        public DateTime DataDaPublicacao { get; set; }

        [Required(ErrorMessage = "O assunto é obrigatório!")]
        [MinLength(5, ErrorMessage = "Você deve digitar ao menos 5 caracteres.")]
        [StringLength(100, ErrorMessage = "O assunto deve ter no máximo 100 caracteres.")]
        public string Assunto { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição é obrigatória!")]
        [MinLength(20, ErrorMessage = "Você deve digitar ao menos 20 caracteres.")]
        public string Descricao { get; set; }
    }
}