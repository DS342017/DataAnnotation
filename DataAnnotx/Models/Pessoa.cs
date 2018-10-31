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
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public String Nome { get; set; }
        [StringLength(14, MinimumLength =14)]
        [Display(Name ="CPF")]
        [Required(ErrorMessage ="Este Campo é Obrigatório")]
        
        [RegularExpression("[0-9]{3}\\.[0-9]{3}\\.[0-9]{3}\\-[0-9]{2}", ErrorMessage ="Exemplo: XXX.XXX.XXX-XX")]
        public String Cpf { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$")]
        public String RG { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage ="Este campo é Obrigado")]
        [DataType(DataType.Date)]
        public String DataNascimento { get; set; }
        [DataType(DataType.EmailAddress)]
        public String Endereco { get; set; }
        [Display(Name ="Número")]
        public int NumEnd { get; set; }
        [DataType(DataType.Password)]
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        [DataType(DataType.PostalCode)]
        public String CEP { get; set; }
        public String Detalhes { get; set; }
    }
}