using MotoTaxi.API.Application.Models.DTOs;

namespace MotoTaxi.API.Application.Models.Requests
{
    public record AddMotoqueiroRequest(string Nome, string Apelido, DateTime DataNascimento, 
        string Telefone, string TelefoneEmergencia, string Endereco, string Rg, string Cpf, DateTime DataVencimentoCnh,
        string EstadoCivil, DateTime DataContratacao, bool Ativo, DateTime? DataDesligamento)
    {
    }
}
