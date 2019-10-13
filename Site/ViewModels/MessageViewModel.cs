using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.ViewModels
{
    public class MessageViewModel
    {
        [Key]
        public int MessageId { get; set; }

        [Required(ErrorMessage = "Escreva uma mensagem")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Máximo {0} caracteres")]
        public string Texto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Lido { get; set; }
    }
}