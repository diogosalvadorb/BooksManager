using BooksManager.Application.Commands.Loans.CreateLoan;
using BooksManager.Application.Commands.Loans.FinishLoan;
using BooksManager.Application.Queries.Loans.GetLoan;
using BooksManager.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoanById([FromRoute] int id)
        {
            var loan = await _mediator.Send(new GetLoanByIdQuery(id));

            if(loan == null)
            {
                return NotFound();
            }

            return Ok(loan);  
        }

        [HttpPost]
        public async Task<IActionResult> CreateLoan(CreateLoanCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetLoanById), new { Id = id }, command);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> FinishLoan([FromRoute] int id)
        {
            var loan = await _mediator.Send(new FinishLoanCommand(id));

            if (loan == null)
            {
                return NotFound();
            }

            return Ok(loan);
        }
    }
}
