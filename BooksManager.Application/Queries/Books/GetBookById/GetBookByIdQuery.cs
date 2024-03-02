using BooksManager.Application.ViewModels;
using MediatR;

namespace BooksManager.Application.Queries.Books.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookViewModel>
    {
        public GetBookByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
