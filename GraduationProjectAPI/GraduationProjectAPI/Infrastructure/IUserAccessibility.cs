using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IUserAccessibility
    {
        public UserAccessibility GetUserAccessibility(int id);
        public IQueryable<UserAccessibility> GetUserAccessibilities { get; }
        public void Save(UserAccessibility userAccessibility);
        public void Update(UserAccessibility userAccessibility);
        public void Delete(int id);
    }
}
