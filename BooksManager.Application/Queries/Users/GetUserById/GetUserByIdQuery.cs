using BooksManager.Application.ViewModels;
using MediatR;

namespace BooksManager.Application.Queries.Users.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserViewModel>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
