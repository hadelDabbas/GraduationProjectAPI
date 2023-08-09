using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface ILibrary
    {
        public Library GetLibrary(int id);
        public IQueryable<Library> GetLibraries { get; }
        public bool Save(Library library);
        public void Update(Library library);
        public void Delete(Library library);
        public List<Book> GetBookLibrary(int IdLibrary);
        public List<Book> GetBookWriters(int IdLibrary, int IdWriter);
        public List<Book> GetBookType(int IdLibrary, int IdType);
        public List<BookType> GetLibraryBookType(int IdLibrary);
    }
}
