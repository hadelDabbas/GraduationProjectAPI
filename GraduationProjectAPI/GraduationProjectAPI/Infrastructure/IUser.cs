using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IUser
    {
       
        public IQueryable<User> GetUsers { get; }
        public void Save(User user);
        public void Update(User user);
        public void Delete(int id);
        public bool IsExisting(string email,string UserName);
        public bool ChangePassword(string email, string password);
        public User SignIn(string email,string password);
    }
}
