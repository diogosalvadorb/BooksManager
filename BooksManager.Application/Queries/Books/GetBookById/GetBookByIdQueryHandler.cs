using Azure;
using BooksManager.Application.ViewModels;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Queries.Books.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookViewModel>
    {
        private readonly IBookRepository _bookRepository;
        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var responseBook = await _bookRepository.GetByIdAsync(request.Id);

            if (responseBook == null) return null;

            return new BookViewModel(responseBook.Id, responseBook.Title, responseBook.Author, responseBook.Isbn, responseBook.PublicationYear,
                responseBook.Loans.Select(x => new LoanViewModel(x.BookId, x.UserId)).ToList());
        }
    }
}
