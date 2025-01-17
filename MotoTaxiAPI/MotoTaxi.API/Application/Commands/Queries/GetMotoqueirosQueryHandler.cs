using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MotoTaxi.API.Application.Infrastructure;
using MotoTaxi.API.Application.Models.DTOs;
using MotoTaxi.Infrastructure.Data;

namespace MotoTaxi.API.Application.Commands.Queries
{
    public class GetMotoqueirosQueryHandler : IRequestHandler<GetMotoqueirosQuery, IEnumerable<MotoqueiroResult>>
    {
        //private readonly SqlConnectionProvider _sqlConnectionProvider = sqlConnectionProvider ?? throw new ArgumentNullException(nameof(sqlConnectionProvider));

        private readonly ApplicationDataContext _context;

        public GetMotoqueirosQueryHandler(ApplicationDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<MotoqueiroResult>> Handle(GetMotoqueirosQuery request, CancellationToken cancellationToken)
        {
            var motoqueiros = await _context.Motoqueiros
                .AsNoTracking() 
                .ToListAsync(cancellationToken);

            return motoqueiros.Select(x => new MotoqueiroResult
            {
                Nome = x.Nome,
                Apelido = x.Apelido,
            });
        }
    }

    public class GetMotoqueirosQuery : IRequest<IEnumerable<MotoqueiroResult>>
    {
    }
}
