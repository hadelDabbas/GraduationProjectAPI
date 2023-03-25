using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IUserReference
    {
        public UserReference GetUserReference(int id);
        public IQueryable<UserReference> GetUserReferences { get; }
        public void Save(UserReference userReference);
        public void Update(UserReference userReference);
        public void Delete(int id);
    }
}
