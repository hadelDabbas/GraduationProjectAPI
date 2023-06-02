using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class BookTypeRepo : IBookType
    {
        private readonly GraduationProjectDbContext _db;
        public BookTypeRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<BookType> GetBookTypes => _db.BookTypes;

        public void Delete(int id)
        {
            var bookType= _db.BookTypes.FirstOrDefault(p => p.Id == id);
            if (bookType != null)
            {
                _db.BookTypes.Remove(bookType);
                _db.SaveChanges();
            }


        }
        public BookType GetBookType(int id)
        {
            var bookType = _db.BookTypes.First(p => p.Id == id);
            if (bookType != null)
                return bookType;
            else
                return null;

        }
        public void Save(BookType bookType)
        {
            if (bookType.Id == 0)
            {
                if (IsExisting(bookType))
                {
                    _db.BookTypes.Add(bookType);
                    _db.SaveChanges();
                }
            }

        }
        public void Update(BookType bookType)
        {
            var BookType = _db.BookTypes.First(p => p.Id == bookType.Id);
            if (BookType != null)
            {
                BookType.bookType = bookType.bookType;
                _db.SaveChanges();
            }
        }
        public bool IsExisting(BookType b)
        {
            bool data = _db.BookTypes.Any(p => p.bookType == b.bookType);
            if (data != false)
                return true;
            else return false;
        }
    }
}
