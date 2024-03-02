using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Commands.Loans.CreateLoan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, int>
    {
        private readonly ILoanRepository _loanRepository;
        public CreateLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<int> Handle(CreateLoanCommand command, CancellationToken cancellationToken)
        {
            var loan = new Loan(command.BookId, command.UserId);
            await _loanRepository.GetByIdAsync(loan.Id);

            return loan.Id;
        }
    }
}
