using MediatR;
using MotoTaxi.API.Application.Models.Requests.MotoqueirosRequest;

namespace MotoTaxi.API.Application.Commands.MotoqueirosCommands
{
    public class AddMotoqueiroCommand(string nome, string apelido, DateTime dataNascimento,
        string telefone, string telefoneEmergencia, string rg, string cpf, DateTime dataVencimentoCnh,
        string estadoCivil, DateTime dataContratacao, bool ativo, DateTime? dataDesligamento, AddEnderecoRequest endereco) : IRequest<bool>
    {
        public string Nome { get; set; } = nome;
        public string Apelido { get; set; } = apelido;
        public DateTime DataNascimento { get; set; } = dataNascimento;
        public string Telefone { get; set; } = telefone;
        public string TelefoneEmergencia { get; set; } = telefoneEmergencia;
        public string Rg { get; set; } = rg;
        public string Cpf { get; set; } = cpf;
        public DateTime DataVencimentoCnh { get; set; } = dataVencimentoCnh;
        public string EstadoCivil { get; set; } = estadoCivil;
        public DateTime DataContratacao { get; set; } = dataContratacao;
        public bool Ativo { get; set; } = ativo;
        public DateTime? DataDesligamento { get; set; } = dataDesligamento;
        public AddEnderecoRequest Endereco { get; set; } = endereco;
    }
}
