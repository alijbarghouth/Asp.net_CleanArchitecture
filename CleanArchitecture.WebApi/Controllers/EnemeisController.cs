using CleanArchitecture.Application.Command.EnemyCommand;
using CleanArchitecture.WebApi.Filter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApplicationExceptionHandlerFilter]
    public class EnemiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EnemiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("addEnemy")]
        public async Task<ActionResult<object>> AddEnemyAsync(AddEnemyCommand request)
        {
            var result = await _mediator.Send(request);

            return Ok(new {result = result});
        }
    }
}