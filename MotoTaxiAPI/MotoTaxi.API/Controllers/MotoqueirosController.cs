using MediatR;
using Microsoft.AspNetCore.Mvc;
using MotoTaxi.API.Application.Commands;
using MotoTaxi.API.Application.Commands.Queries;
using MotoTaxi.API.Application.Models.Requests.MotoqueirosRequest;

namespace MotoTaxi.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MotoqueirosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MotoqueirosController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add([FromBody] AddMotoqueiroRequest request)
        {
            var cmd = new AddMotoqueiroCommand(request.Nome, request.Apelido, request.DataNascimento, request.Telefone,
                request.TelefoneEmergencia, request.Rg, request.Cpf, request.DataVencimentoCnh, request.EstadoCivil,
                request.DataContratacao, request.Ativo, request.DataDesligamento);
            var result = await _mediator.Send(cmd);

            if(result == false) 
                return BadRequest();

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            var cmd = new GetMotoqueirosQuery();
            var data = await _mediator.Send(cmd);

            if (data == null || !data.Any())
                return NoContent();

            return Ok(data);
        }

    }
}
