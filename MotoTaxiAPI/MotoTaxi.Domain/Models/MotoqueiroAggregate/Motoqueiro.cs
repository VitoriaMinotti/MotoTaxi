﻿using MotoTaxi.Domain.Core;

namespace MotoTaxi.Domain.Models.MotoqueiroAggregate
{
    public class Motoqueiro : Entity<Guid>
    {
        public Motoqueiro(string nome, string apelido, DateTime dataNascimento,
        string telefone, string telefoneEmergencia, string endereco, string rg, string cpf, DateTime dataVencimentoCnh,
        string estadoCivil, DateTime dataContratacao, bool ativo, DateTime? dataDesligamento)
        {
            Nome = nome;
            Apelido = apelido;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            TelefoneEmergencia = telefoneEmergencia;
            Endereco = endereco;
            Rg = rg;
            Cpf = cpf;
            DataVencimentoCnh = dataVencimentoCnh;
            EstadoCivil = estadoCivil;
            DataContratacao = dataContratacao;
            Ativo = ativo;
            DataDesligamento = dataDesligamento;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string TelefoneEmergencia { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataVencimentoCnh { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataContratacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataDesligamento { get; set; } 

        public Motoqueiro() { }

    }
}