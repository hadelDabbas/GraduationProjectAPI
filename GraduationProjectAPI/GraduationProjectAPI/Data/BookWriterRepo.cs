using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class BookWriterRepo : IBookWriter
    {
        private readonly GraduationProjectDbContext _db;
        public BookWriterRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<BookWriter> GetBookWriters => _db.BookWriters;

        public void Delete(int id)
        {
            var bookWriter = _db.BookWriters.FirstOrDefault(p => p.Id == id);
            if (bookWriter != null)
            {
                _db.BookWriters.Remove(bookWriter);
                _db.SaveChanges();
            }


        }
        public BookWriter GetBookWriter(int id)
        {
            var bookWriter = _db.BookWriters.FirstOrDefault(p => p.Id == id);
            if (bookWriter != null)
                return bookWriter;
            else
                return null;

        }
        public void Save(BookWriter bookWriter)
        {
            if (bookWriter.Id == 0)
            {
                _db.BookWriters.Add(bookWriter);
                _db.SaveChanges();
            }

        }
        public void Update(BookWriter bookWriter)
        {
            var BookWriter = _db.BookWriters.First(p => p.Id == bookWriter.Id);
            if (BookWriter != null)
            {
                BookWriter.IdBook = bookWriter.IdBook;
                BookWriter.IdWriter = bookWriter.IdWriter;
                _db.SaveChanges();
            }
        }
    }
}
