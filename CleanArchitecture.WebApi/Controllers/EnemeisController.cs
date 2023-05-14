using CleanArchitecture.Application.Command.EnemyCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemeisController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EnemeisController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("addEnemy")]
        public async Task<IActionResult> AddEnemyAsync(AddEnemyCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
