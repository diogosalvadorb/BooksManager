using BooksManager.Application.Commands.Books.CreateBook;
using BooksManager.Application.Commands.Books.DeleteBook;
using BooksManager.Application.Queries.Books.GetAllBooks;
using BooksManager.Application.Queries.Books.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookd()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _mediator.Send(new GetBookByIdQuery(id));

            if(book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetBookById), new { Id = id }, command);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _mediator.Send(new DeleteBookCommand(id));

            return NoContent();
        }
    }
}
