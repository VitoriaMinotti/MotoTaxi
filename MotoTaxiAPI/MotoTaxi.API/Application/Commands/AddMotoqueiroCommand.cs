using MediatR;
using MotoTaxi.API.Application.Models.DTOs;

namespace MotoTaxi.API.Application.Commands
{
    public class AddMotoqueiroCommand(string nome, string apelido, DateTime dataNascimento, 
        string telefone, string telefoneEmergencia, string endereco, string rg, string cpf, DateTime dataVencimentoCnh,
        string estadoCivil, DateTime dataContratacao, bool ativo, DateTime? dataDesligamento) : IRequest<bool>
    {
        public string Nome { get; set; } = nome;
        public string Apelido { get; set; } = apelido;
        public DateTime DataNascimento { get; set; } = dataNascimento;
        public string Telefone { get; set; } = telefone;
        public string TelefoneEmergencia { get; set; } = telefoneEmergencia;
        public string Endereco { get; set; } = endereco;
        public string Rg { get; set; } = rg;
        public string Cpf { get; set; } = cpf;
        public DateTime DataVencimentoCnh { get; set; } = dataVencimentoCnh;
        public string EstadoCivil { get; set; } = estadoCivil;
        public DateTime DataContratacao { get; set; } = dataContratacao;
        public List<MotosDTO> Motos { get; set; } = new List<MotosDTO>();
        public bool Ativo { get; set; } = ativo;
        public DateTime? DataDesligamento { get; set; } = dataDesligamento;
    }
}
