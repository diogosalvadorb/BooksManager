using BooksManager.Core.Entities;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Commands.Loans.FinishLoan
{
    public class FinishLoanCommandHandler : IRequestHandler<FinishLoanCommand, Unit>
    {
        private readonly ILoanRepository _loanRepository;

        public FinishLoanCommandHandler(ILoanRepository repository)
        {
            _loanRepository = repository;
        }

        public async Task<Unit> Handle(FinishLoanCommand command, CancellationToken cancellationToken)
        {
            var loancompleted = await _loanRepository.GetByIdAsync(command.Id);

            if (loancompleted == null)
            {
                throw new ArgumentNullException("Nenhum empréstimo encontrado");
            }

            loancompleted.ConfirmReturn();

            if (loancompleted.DueDate > DateTime.Now)
            {
                var daysLate = (DateTime.Now.Date - loancompleted.DueDate.Date).Days;
                Console.WriteLine($"Empréstimo devolvido com {daysLate} dias de atraso.");
            }

            return Unit.Value;
        }
    }
}
