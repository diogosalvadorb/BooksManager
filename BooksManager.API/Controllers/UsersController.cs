using BooksManager.Application.Commands.Users.CreateUser;
using BooksManager.Application.Queries.Users.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var queryResult = await _mediator.Send(new GetUserByIdQuery(id));

            if(queryResult == null)
            {
                return NotFound();
            }

            return Ok(queryResult);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetUserById), new { id = id }, command);
        }
    }
}
