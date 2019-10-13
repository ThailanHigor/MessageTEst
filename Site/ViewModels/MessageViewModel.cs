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
        [MinLength(10, ErrorMessage = "Mínimo 10 caracteres")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string Texto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Informe a data de exibição")]
        [Display(Name = "Data exibição da Mensagem")]
        public DateTime DataExibicao { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Lido { get; set; }
    }
}