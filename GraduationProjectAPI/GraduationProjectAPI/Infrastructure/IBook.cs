using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IBook
    {
        public Book GetBook(int id);
        public IQueryable<Book> GetBooks { get; }
        public void Save(Book book);
        public void Update(Book book);
        public void Delete(int id);
    }
}
