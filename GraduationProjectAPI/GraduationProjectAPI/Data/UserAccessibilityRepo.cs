using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class UserAccessibilityRepo: IUserAccessibility
    {
        private readonly GraduationProjectDbContext _db;
        public UserAccessibilityRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<UserAccessibility> GetUserAccessibilities => _db.UserAccessibilities;

        public void Delete(int id)
        {
            var userAccessibility = _db.UserAccessibilities.FirstOrDefault(p => p.Id == id);
            if (userAccessibility != null)
            {
                _db.UserAccessibilities.Remove(userAccessibility);
                _db.SaveChanges();
            }


        }
        public UserAccessibility GetUserAccessibility(int id)
        {
            var userAccessibility = _db.UserAccessibilities.First(p => p.Id == id);
            if (userAccessibility!= null)
                return userAccessibility;
            else
                return null;

        }
        public void Save(UserAccessibility userAccessibility)
        {
            if (userAccessibility.Id == 0)
            {

                _db.UserAccessibilities.Add(userAccessibility);
                _db.SaveChanges();

            }

        }
        public void Update(UserAccessibility userAccessibility)
        {
            var UserAccessibility = _db.UserAccessibilities.First(p => p.Id == userAccessibility.Id);
            if (UserAccessibility != null)
            {
                UserAccessibility.IdUser = userAccessibility.IdUser ;
                UserAccessibility.IdAccessibility = userAccessibility.IdAccessibility;
                UserAccessibility.AdminOn = userAccessibility.AdminOn;
                UserAccessibility.IdGroup = userAccessibility.IdGroup;
                UserAccessibility.IdLibrary = userAccessibility.IdLibrary;
                _db.SaveChanges();
            }
        }
    }
}
