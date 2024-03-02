using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Commands.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User(command.Name, command.Email);
            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}
