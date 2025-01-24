using MotoTaxi.Domain.Models.MotoqueiroAggregate;

namespace MotoTaxi.API.Application.Models.Requests.MotoqueirosRequest
{
    public record AddMotoqueiroRequest(string Nome, string Apelido, DateTime DataNascimento,
        string Telefone, string TelefoneEmergencia, string Rg, string Cpf, DateTime DataVencimentoCnh,
        string EstadoCivil, DateTime DataContratacao, bool Ativo, DateTime? DataDesligamento, Endereco Endereco)
    {
    }
}
