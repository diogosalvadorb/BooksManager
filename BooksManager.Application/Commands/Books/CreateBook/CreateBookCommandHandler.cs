using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Commands.Books.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;
        public CreateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(CreateBookCommand command, CancellationToken cancellationToken)
        {
            var book = new Book(command.Title, command.Author, command.Isbn, command.PublicationYear);
            await _bookRepository.AddAsync(book);

            return book.Id;
        }
    }
}
