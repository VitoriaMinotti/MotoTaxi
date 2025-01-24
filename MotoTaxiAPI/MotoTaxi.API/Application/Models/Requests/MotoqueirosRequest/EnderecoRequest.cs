namespace MotoTaxi.API.Application.Models.Requests.MotoqueirosRequest
{
    public record EnderecoRequest(string rua, string numero, string bairro, string cidade, string estado, string cep)
    {
    }
}
