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
            var Library = _db.Libraries.First(p => p.Id == library.Id);
            if (Library != null)
            {
                Library.libraryAddress = library.libraryAddress;
                Library.libraryName = library.libraryName;
                _db.SaveChanges();
            }
        }
    }
}
