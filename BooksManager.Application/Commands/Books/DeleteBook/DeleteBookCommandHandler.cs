using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Commands.Books.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;
        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(DeleteBookCommand command, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsync(command.Id);

            if (book == null)
            {
                throw new ArgumentNullException("Nenhum livro encontrado");
            }

            book.Delete();

            await _bookRepository.SaveChangesAsync();

            return Unit.Value;
        }
    } 
}
