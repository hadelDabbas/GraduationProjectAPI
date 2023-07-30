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

        public void Delete(int id)
        {
            var library = _db.Libraries.FirstOrDefault(p => p.Id == id);
            if (library != null)
            {
                _db.Libraries.Remove(library);
                _db.SaveChanges();
            }


        }
        public Library GetLibrary(int id)
        {
            var library = _db.Libraries.First(p => p.Id == id);
            if (library != null)
                return library;
            else
                return null;

        }
        public void Save(Library library)
        {
            if (library.Id == 0)
            {
                _db.Libraries.Add(library);
                _db.SaveChanges();
            }

        }
        public void Update(Library library)
        {
            var Library = _db.Libraries.FirstOrDefault(p => p.Id == library.Id);
            if (Library != null)
            {
                Library.libraryAddress = library.libraryAddress;
                Library.libraryName = library.libraryName;
                _db.SaveChanges();
            }
        }
        public List<Book> GetBookLibrary(int IdLibrary)
        {
            List<Book> Book = new List<Book>();
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            if(library != null)
            {
                List<BookLibrary> books = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary).ToList();
                foreach(BookLibrary e in books)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook);
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
            var writer = _db.Writers.FirstOrDefault(p => p.Id == IdWriter);
            List<BookWriter> bookWriters=new List<BookWriter>();
            List<Book> book = new List<Book>();
            if(library != null && writer != null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                    // List<BookWriter> books = _db.Writers.Where(p => p.Id == IdWriter && p.id).SelectMany(p => p.BookWriter).ToList();
                  BookWriter  c = _db.BookWriters.FirstOrDefault(p => p.IdWriter == IdWriter && p.IdBook == e.IdBook);
                  if(c!= null)
                    bookWriters.Add(c);
                }
                foreach(BookWriter e in bookWriters)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook);
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
            var bookType = _db.BookTypes.Where(p => p.Id == IdType);
            List<Book> book = new List<Book>();
            if (library != null && bookType != null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                    Book b = _db.Books.FirstOrDefault(p => p.Id == e.IdBook && p.IdBookType == IdType);
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
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            if(library!= null)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
