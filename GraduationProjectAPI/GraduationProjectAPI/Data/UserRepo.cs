using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class UserRepo:IUser
    {
        private readonly GraduationProjectDbContext _db;
        public UserRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<User> GetUsers => _db.Users;

        public void Delete(int id)
        {
            var user = _db.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }


        }
        public User GetUser(int id)
        {
            var user = _db.Users.First(p => p.Id == id);
            if (user != null)
                return user;
            else
                return null;

        }
        public void Save(User user)
        {
            if (user.Id == 0)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }

        }
        public void Update(User user)
        {
            var User = _db.Users.First(p => p.Id == user.Id);
            if (User != null)
            {
                User.Address = user.Address;
                User.Age = user.Age;
                User.Email = user.Email;
                User.Image = user.Image;
                User.Name = user.Name;
                User.Password = user.Password;
                User.Paypal = user.Paypal;
                User.Phone = user.Phone;
                User.Study = user.Study;
                User.UserName = user.UserName;
                _db.SaveChanges();
            }
        }
    }
}
