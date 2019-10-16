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
        [Display(Name = "Mensagem")]
        public string Texto { get; set; }

        [ScaffoldColumn(false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Informe a data de exibição")]
        [Display(Name = "Data exibição da Mensagem")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataExibicao { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public bool Lido { get; set; }
    }
}