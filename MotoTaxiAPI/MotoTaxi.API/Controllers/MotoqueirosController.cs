using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MotoTaxi.API.Application.Models.Requests;

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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add([FromBody] AddMotoqueiroRequest request)
    }
}
