using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManager.Application.ViewModels
{
    public class LoanViewModel
    {
        public LoanViewModel(int bookId, int userId)
        {
            BookId = bookId;
            UserId = userId;
        }

        public int BookId { get; private set; }
        public int UserId { get; private set; }
        public DateTime? LoanDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public DateTime? DueDate { get; private set; }
    }
}
