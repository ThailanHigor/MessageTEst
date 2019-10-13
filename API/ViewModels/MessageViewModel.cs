using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.ViewModels
{
    public class MessageViewModel
    {
        [Key]
        public int MessageId { get; set; }

        public string Texto { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataExibicao { get; set; }

        public bool Ativo { get; set; }

        public bool Lido { get; set; }
    }
}