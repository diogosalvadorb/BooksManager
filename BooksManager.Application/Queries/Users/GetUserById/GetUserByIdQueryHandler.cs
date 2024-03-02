using BooksManager.Application.ViewModels;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Queries.Users.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var responseUser = await _userRepository.GetByIdAsync(request.Id);

            if (responseUser == null) return null;

            return new UserViewModel(responseUser.FullName, responseUser.Email);
        }
    }
}
