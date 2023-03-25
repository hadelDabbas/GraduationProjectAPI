using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IBookWriter
    {
        public BookWriter GetBookWriter(int id);
        public IQueryable<BookWriter> GetBookWriters { get; }
        public void Save(BookWriter bookWriter);
        public void Update(BookWriter bookWriter);
        public void Delete(int id);
    }
}
