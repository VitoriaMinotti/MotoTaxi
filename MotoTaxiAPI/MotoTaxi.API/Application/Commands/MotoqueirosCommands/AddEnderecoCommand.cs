using MediatR;

namespace MotoTaxi.API.Application.Commands.MotoqueirosCommands
{
    public class AddEnderecoCommand(string rua, string numero, string bairro, string cidade, string estado, string cep) : IRequest<bool>
    {
        public string Rua { get; set; } = rua;
        public string Numero { get; set; } = numero;
        public string Bairro { get; set;} = bairro;
        public string Cidade { get; set; } = cidade;
        public string Estado { get; set; } = estado;
        public string CEP { get; set; } = cep;

    }
}
