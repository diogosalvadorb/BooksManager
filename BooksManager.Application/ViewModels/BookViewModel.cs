namespace BooksManager.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(int id, string title, string author, string isbn, int publicationDate, List<LoanViewModel> loans)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            PublicationDate = publicationDate;
            Loans = loans;
        }

        public int Id { get; init; }
        public string Title { get; init; }
        public string Author { get; init; }
        public string Isbn { get; init; }
        public int PublicationDate { get; init; }
        public List<LoanViewModel> Loans { get; init; }
    }
}
