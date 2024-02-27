namespace BooksManager.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            Active = true;
        }

        public string FullName { get; private set; } 
        public string Email { get; private set; } 
        public bool Active { get; private set; }
        public List<Loan> Loans { get; private set; }
    }
}
