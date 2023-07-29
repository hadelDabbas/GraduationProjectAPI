using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IWriter
    {
        public Writer GetWriter(int id);
        public IQueryable<Writer> GetWriters { get; }
        public void Save(Writer writer);
        public void Update(Writer writer);
        public void Delete(int id);
        
    }
}
