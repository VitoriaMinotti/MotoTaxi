using MotoTaxi.Domain.Core;

namespace MotoTaxi.Domain.Models.MotoqueiroAggregate
{
    public class Motoqueiro : Entity<Guid>
    {
        public Motoqueiro(string nome, string apelido, DateTime dataNascimento,
        string telefone, string telefoneEmergencia, string rg, string cpf, DateTime dataVencimentoCnh,
        string estadoCivil, DateTime dataContratacao, bool ativo, DateTime? dataDesligamento, Endereco enderecoMotoqueiro)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Apelido = apelido;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            TelefoneEmergencia = telefoneEmergencia;
            Rg = rg;
            Cpf = cpf;
            DataVencimentoCnh = dataVencimentoCnh;
            EstadoCivil = estadoCivil;
            DataContratacao = dataContratacao;
            Ativo = ativo;
            DataDesligamento = dataDesligamento;
            Endereco = enderecoMotoqueiro;
        }

        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string TelefoneEmergencia { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataVencimentoCnh { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataContratacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataDesligamento { get; set; } 

    }
}
