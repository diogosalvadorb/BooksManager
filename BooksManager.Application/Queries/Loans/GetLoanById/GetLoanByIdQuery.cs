using BooksManager.Application.ViewModels;
using MediatR;

namespace BooksManager.Application.Queries.Loans.GetLoan
{
    public class GetLoanByIdQuery : IRequest<LoanViewModel>
    {
        public GetLoanByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
