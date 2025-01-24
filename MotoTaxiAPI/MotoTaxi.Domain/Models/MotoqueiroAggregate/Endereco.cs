using MotoTaxi.Domain.Core;

namespace MotoTaxi.Domain.Models.MotoqueiroAggregate
{
    public class Endereco : Entity<Guid>
    {
        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            Id = Guid.NewGuid();
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        public string Rua {  get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
    }
}
