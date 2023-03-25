using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface ILibrary
    {
        public Library GetLibrary(int id);
        public IQueryable<Library> GetLibraries { get; }
        public void Save(Library library);
        public void Update(Library library);
        public void Delete(int id);
    }
}
