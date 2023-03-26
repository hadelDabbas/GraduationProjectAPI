using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class BookLibraryRepo:IBookLibrarycs
    {
        private readonly GraduationProjectDbContext _db;
        public BookLibraryRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<BookLibrary> GetBookLibraries => _db.BookLibraries;

        public void Delete(int id)
        {
            var bookLibrary = _db.BookLibraries.FirstOrDefault(p => p.Id == id);
            if (bookLibrary != null)
            {
                _db.BookLibraries.Remove(bookLibrary);
                _db.SaveChanges();
            }


        }
        public BookLibrary GetBookLibrary(int id)
        {
            var bookLibrary = _db.BookLibraries.First(p => p.Id == id);
            if (bookLibrary != null)
                return bookLibrary;
            else
                return null;

        }
        public void Save(BookLibrary bookLibrary)
        {
            if (bookLibrary.Id == 0)
            {
                _db.BookLibraries.Add(bookLibrary);
                _db.SaveChanges();
            }

        }
        public void Update(BookLibrary bookLibrary)
        {
            var booklibrary = _db.BookLibraries.First(p => p.Id == bookLibrary.Id);
            if (booklibrary != null)
            {
                booklibrary.IdBook = bookLibrary.IdBook;
                booklibrary.IdLibrary = bookLibrary.IdLibrary;
                _db.SaveChanges();
            }
        }
    }
}
