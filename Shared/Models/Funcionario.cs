using System;
using System.ComponentModel.DataAnnotations;

namespace Somar.Shared.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtAdmissao { get; set; }
        public DateTime? DtDemissao { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o seu usuário!")]
        public string Usuario { get; set; }


        [Required(ErrorMessage = "Informe sua senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public int FuncaoId { get; set; }
        public virtual Funcao Funcao { get; set; }
        public bool Antecipar { get; set; }
        public int TurnoId { get; set; }
        public virtual Turno Turno { get; set; }
    }
}
