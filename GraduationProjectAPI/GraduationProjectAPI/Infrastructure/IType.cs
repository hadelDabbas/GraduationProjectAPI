using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IType
    {
        public Model.Type GetType(int id);
        public IQueryable<Model.Type> GetTypes { get; }
        public void Save(Model.Type type);
        public void Update(Model.Type type);
        public void Delete(int id);
    }
}
