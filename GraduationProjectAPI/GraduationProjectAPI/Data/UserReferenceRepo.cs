using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class UserReferenceRepo:IUserReference
    {
        private readonly GraduationProjectDbContext _db;
        public UserReferenceRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<UserReference> GetUserReferences => _db.UserReferences;

        public void Delete(int id)
        {
            var userReference = _db.UserReferences.FirstOrDefault(p => p.Id == id);
            if (userReference != null)
            {
                _db.UserReferences.Remove(userReference);
                _db.SaveChanges();
            }


        }
        public UserReference GetUserReference(int id)
        {
            var userReference = _db.UserReferences.First(p => p.Id == id);
            if (userReference != null)
                return userReference;
            else
                return null;

        }
        public void Save(UserReference userReference)
        {
            if (userReference.Id == 0)
            {
                _db.UserReferences.Add(userReference);
                _db.SaveChanges();
            }

        }
        public void Update(UserReference userReference)
        {
            var UserReference = _db.UserReferences.First(p => p.Id == userReference.Id);
            if (userReference != null)
            {
                UserReference.IdReference = userReference.IdReference;
                UserReference.IdUser = userReference.IdUser;
                _db.SaveChanges();
            }
        }
    }
}
