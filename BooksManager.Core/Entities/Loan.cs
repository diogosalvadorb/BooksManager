namespace BooksManager.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int bookId, int userId)
        {
            BookId = bookId;
            UserId = userId;
        }

        public int UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; private set; }
        public DateTime DueDate { get; set; }
    }
}
