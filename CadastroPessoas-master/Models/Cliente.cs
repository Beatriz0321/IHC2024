using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroPessoas.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public DateTime DataNascimento { get; set; }
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;

        public string UF { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "O estado civil é obrigatório.")]
        [EnumDataType(typeof(EstadoCivil), ErrorMessage = "Estado civil inválido.")]
        public EstadoCivil EstadoCivil { get; set; }

        public string NomePai { get; set; } = string.Empty;
        public string NomeMae { get; set; } = string.Empty;
    }

    public enum EstadoCivil
    {
        Casado,
        Solteiro,
        Divorciado,
        Viuvo
    }
}
