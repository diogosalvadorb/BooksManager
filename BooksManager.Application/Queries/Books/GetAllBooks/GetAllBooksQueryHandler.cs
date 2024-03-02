using BooksManager.Application.ViewModels;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Queries.Books.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        private readonly IBookRepository _bookRepository;
        public GetAllBooksQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllAsync();

            return books
                .Select(x => new BookViewModel(x.Id, x.Title, x.Author, x.Isbn, x.PublicationYear, 
                x.Loans.Select(x => new LoanViewModel(x.BookId, x.UserId)).ToList())).ToList();
        }
    }
}
