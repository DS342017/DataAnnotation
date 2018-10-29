using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotx.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String RG { get; set; }
        public String DataNascimento { get; set; }
        public String Endereco { get; set; }
        public int NumEnd { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String CEP { get; set; }
        public String Detalhes { get; set; }
    }
}