namespace BooksManager.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string isbn, int publicationDate)
        {
            Title = title; 
            Author = author; 
            ISBN = isbn; 
            PublicationYear = publicationDate;
        }

        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int PublicationYear { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
