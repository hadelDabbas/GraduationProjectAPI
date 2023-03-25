using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IGroup
    {
        public Group GetGroup(int id);
        public IQueryable<Group> GetGroups { get; }
        public void Save(Group group);
        public void Update(Group group);
        public void Delete(int id);
    }
}
