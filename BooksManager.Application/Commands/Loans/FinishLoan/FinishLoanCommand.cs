using BooksManager.Application.ViewModels;
using MediatR;

namespace BooksManager.Application.Commands.Loans.FinishLoan
{
    public class FinishLoanCommand : IRequest<Unit>
    {
        public int Id { get; private set; }

        public FinishLoanCommand(int id)
        {
            Id = id;
        }
    }
}
