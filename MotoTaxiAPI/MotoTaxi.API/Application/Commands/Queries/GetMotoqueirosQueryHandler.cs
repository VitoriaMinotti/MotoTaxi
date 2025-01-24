using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MotoTaxi.API.Application.Infrastructure;
using MotoTaxi.API.Application.Models.DTOs.Motoqueiros;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;
using MotoTaxi.Infrastructure.Data;

namespace MotoTaxi.API.Application.Commands.Queries
{
    public class GetMotoqueirosQueryHandler(IMotoqueiroRepository motoqueiroRepository) : IRequestHandler<GetMotoqueirosQuery, IEnumerable<MotoqueiroResult>>
    {
        private readonly IMotoqueiroRepository _motoqueiroRepo = motoqueiroRepository ?? throw new Exception(nameof(motoqueiroRepository));

        public async Task<IEnumerable<MotoqueiroResult>> Handle(GetMotoqueirosQuery request, CancellationToken cancellationToken)
        {
            var motoqueiros = _motoqueiroRepo.GetAll();

            return motoqueiros.Select(x => new MotoqueiroResult
            {
                Nome = x.Nome,
                Apelido = x.Apelido,
                DataNascimento = x.DataNascimento,
                Telefone = x.Telefone,
                TelefoneEmergencia = x.TelefoneEmergencia,
                Rg = x.Rg,
                Cpf = x.Cpf,
                DataVencimentoCnh = x.DataVencimentoCnh,
                EstadoCivil = x.EstadoCivil,
                DataContratacao = x.DataContratacao,
                Ativo = x.Ativo,
                DataDesligamento = x.DataDesligamento
            });
        }
    }
    public class GetMotoqueirosQuery : IRequest<IEnumerable<MotoqueiroResult>>
    {
    }
}
