using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class WriterRepo:IWriter
    {
        private readonly GraduationProjectDbContext _db;
        public WriterRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Writer> GetWriters => _db.Writers;

        public void Delete(int id)
        {
            var writer = _db.Writers.FirstOrDefault(p => p.Id == id);
            if (writer != null)
            {
                _db.Writers.Remove(writer);
                _db.SaveChanges();
            }


        }
        public Writer GetWriter(int id)
        {
            var writer = _db.Writers.First(p => p.Id == id);
            if (writer != null)
                return writer;
            else
                return null;

        }
        public void Save(Writer writer)
        {
            if (writer.Id == 0)
            {
                _db.Writers.Add(writer);
                _db.SaveChanges();
            }

        }
        public void Update(Writer writer)
        {
            var Writer = _db.Writers.First(p => p.Id == writer.Id);
            if (Writer != null)
            {
                Writer.writerName = writer.writerName;
                _db.SaveChanges();
            }
        }
    }
}
