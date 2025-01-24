namespace MotoTaxi.API.Application.Models.DTOs.Motoqueiros
{
    public class MotoqueirosDTO
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string TelefoneEmergencia { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataVencimentoCnh { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataContratacao { get; set; }
        public List<MotosDTO> Motos { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataDesligamento { get; set; }
    }
}
