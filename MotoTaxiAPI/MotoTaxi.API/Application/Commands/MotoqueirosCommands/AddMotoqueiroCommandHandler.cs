using MediatR;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;

namespace MotoTaxi.API.Application.Commands.MotoqueirosCommands
{
    public class AddMotoqueiroCommandHandler(IMotoqueiroRepository motoqueirosRepository) : IRequestHandler<AddMotoqueiroCommand, bool>
    {
        private readonly IMotoqueiroRepository _motoqueirosRepository = motoqueirosRepository ?? throw new ArgumentNullException(nameof(motoqueirosRepository));

        public async Task<bool> Handle(AddMotoqueiroCommand request, CancellationToken cancellationToken)
        {
            var motoqueiro = new Motoqueiro(request.Nome, request.Apelido, request.DataNascimento, request.Telefone,
                request.TelefoneEmergencia, request.Rg, request.Cpf, request.DataVencimentoCnh, request.EstadoCivil,
                request.DataContratacao, request.Ativo, request.DataDesligamento, request.Endereco);

            _motoqueirosRepository.Add(motoqueiro);
            _motoqueirosRepository.SaveChanges();

            return true;
        }
    }
}
