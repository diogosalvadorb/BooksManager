namespace BooksManager.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int bookId, int userId)
        {
            BookId = bookId;
            UserId = userId;
            LoanDate = DateTime.Now;
            DueDate = DateTime.UtcNow.AddDays(7);
        }

        public int UserId { get; private set; }
        public User User { get; private set; }
        public int BookId { get; private set; }
        public Book Book { get; private set; }
        public DateTime? LoanDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public DateTime DueDate { get; private set; }

        public void ConfirmReturn()
        {
            ReturnDate = DateTime.UtcNow;
        }
    }
}
