using Azure;
using BooksManager.Application.ViewModels;
using BooksManager.Core.Repositories;
using MediatR;

namespace BooksManager.Application.Queries.Loans.GetLoan
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, LoanViewModel>
    {
        private readonly ILoanRepository _loanRepository;
        public GetLoanByIdQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public async Task<LoanViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            var responseLoan = await _loanRepository.GetByIdAsync(request.Id);

            if (responseLoan == null) return null;

            return new LoanViewModel(responseLoan.BookId, responseLoan.UserId);
        }
    }
}
