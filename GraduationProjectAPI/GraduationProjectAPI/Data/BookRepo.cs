using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class BookRepo:IBook
    {
        private readonly GraduationProjectDbContext _db;
        public BookRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Book> GetBooks => _db.Books;

        public void Delete(int id)
        {
            var book = _db.Books.FirstOrDefault(p => p.Id == id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
            }


        }
        public Book GetBook(int id)
        {
            var book = _db.Books.First(p => p.Id == id);
            if (book != null)
                return book;
            else
                return null;

        }
        public void Save(Book book)
        {
            if (book.Id == 0)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
            }

        }
        public void Update(Book book)
        {
            var Book = _db.Books.First(p => p.Id == book.Id);
            if (Book != null)
            {
                Book.bookImage = book.bookImage;
                Book.BookName = book.BookName;
                Book.BookPrice = book.BookPrice;
                Book.IdBookType = book.IdBookType;
                _db.SaveChanges();
            }
        }
    }
}
