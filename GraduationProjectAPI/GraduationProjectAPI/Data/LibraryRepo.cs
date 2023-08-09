using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class LibraryRepo:ILibrary
    {
        private readonly GraduationProjectDbContext _db;
        public LibraryRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Library> GetLibraries => _db.Libraries;

        public void Delete(Library Library)
        {
            var library = _db.Libraries.FirstOrDefault(p => p.Id == Library.Id);
            if (library != null)
            {
                var bookLibrary = _db.BookLibraries.Where(p => p.IdLibrary == library.Id).ToList();
                foreach (BookLibrary e in bookLibrary)
                {
                    e.IsDeleted = true;
                }
                _db.Libraries.Remove(library);
                _db.SaveChanges();
            }


        }
        public Library GetLibrary(int id)
        {
            var library = _db.Libraries.FirstOrDefault(p => p.Id == id);
            if (library != null)
                return library;
            else
                return null;

        }
        public bool Save(Library library)
        {
            if (library.Id == 0)
            {
                if (!IsExisting(library))
                {
                    _db.Libraries.Add(library);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public void Update(Library library)
        {
            var Library = _db.Libraries.FirstOrDefault(p => p.Id == library.Id);
            if (Library != null)
            {
                Library.libraryAddress = library.libraryAddress;
                Library.libraryName = library.libraryName;
               // Library.IsDeleted = library.IsDeleted;
                _db.SaveChanges();
            }
        }
        public List<Book> GetBookLibrary(int IdLibrary)
        {
            List<Book> Book = new List<Book>();
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            if(library != null)
            {
                List<BookLibrary> books = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary && p.IsDeleted==false).ToList();
                foreach(BookLibrary e in books)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook && p.IsDeleted == false);
                    if(b!= null)
                    Book.Add(b);
                }
                if(Book.Count != 0)
                {
                    return Book;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public List<Book> GetBookWriters(int IdLibrary, int IdWriter)
        {
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            var writer = _db.Writers.FirstOrDefault(p => p.Id == IdWriter && p.IsDeleted == false);
            List<BookWriter> bookWriters=new List<BookWriter>();
            List<Book> book = new List<Book>();
            if(library != null && writer != null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary && p.IsDeleted == false).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                    // List<BookWriter> books = _db.Writers.Where(p => p.Id == IdWriter && p.id).SelectMany(p => p.BookWriter).ToList();
                  BookWriter  c = _db.BookWriters.FirstOrDefault(p => p.IdWriter == IdWriter && p.IdBook == e.IdBook && p.IsDeleted == false);
                  if(c!= null)
                    bookWriters.Add(c);
                }
                foreach(BookWriter e in bookWriters)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook && p.IsDeleted == false);
                    if(b!= null)
                    book.Add(b);
                }
                return book;
            }
            else
            {
                return null;
            }
        }
        public List<Book> GetBookType(int IdLibrary, int IdType)
        {
            var library = _db.Libraries.Where(p => p.Id == IdLibrary);
            var bookType = _db.BookTypes.Where(p => p.Id == IdType && p.IsDeleted == false);
            List<Book> book = new List<Book>();
            if (library != null && bookType != null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary && p.IsDeleted == false).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook && p.IdBookType == IdType && p.IsDeleted == false);
                    if (b != null)
                        book.Add(b);
                }
                return book;
            }
            else
            {
                return null;
            }
        }
        public List<BookType> GetLibraryBookType(int IdLibrary)
        {
            List<BookType> data = new List<BookType>();
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            if(library!= null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary && p.IsDeleted == false).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook && p.IsDeleted == false);
                    BookType bookType = _db.BookTypes.FirstOrDefault(p => p.Id == b.IdBookType && p.IsDeleted == false);
                    if(! data.Contains(bookType))
                    {
                        data.Add(bookType);
                    }
                }
                if(data.Count != 0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public bool IsExisting(Library library)
        {
            var data = _db.Libraries.Any(p => p.libraryName == library.libraryName);
            if (data != true)
            {
                return false;
            }
            else return true;
        }
    }
}
