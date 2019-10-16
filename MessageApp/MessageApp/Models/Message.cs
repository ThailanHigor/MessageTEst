using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MessageApp.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Texto { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataExibicao { get; set; }

        public bool Ativo { get; set; }

        public bool Lido { get; set; }
    }
}
