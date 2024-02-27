namespace BooksManager.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string isbn, int publicationYear)
        {
            Title = title; 
            Author = author; 
            Isbn = isbn; 
            PublicationYear = publicationYear;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int PublicationYear { get; private set; }
        public List<Loan> Loans { get; private set; }
    }
}
