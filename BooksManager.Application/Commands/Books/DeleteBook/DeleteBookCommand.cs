using MediatR;

namespace BooksManager.Application.Commands.Books.DeleteBook
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public DeleteBookCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
