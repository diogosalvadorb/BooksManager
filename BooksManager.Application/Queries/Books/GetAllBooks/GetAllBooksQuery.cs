using BooksManager.Application.ViewModels;
using MediatR;

namespace BooksManager.Application.Queries.Books.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookViewModel>>
    {
    }
}
