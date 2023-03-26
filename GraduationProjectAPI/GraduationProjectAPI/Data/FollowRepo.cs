using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class FollowRepo : IFollow
    {
        private readonly GraduationProjectDbContext _db;
        public FollowRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Follow> GetFollows => _db.Follows;

        public void Delete(int id)
        {
            var follow = _db.Follows.FirstOrDefault(p => p.Id == id);
            if (follow != null)
            {
                _db.Follows.Remove(follow);
                _db.SaveChanges();
            }


        }
        public Follow GetFollow(int id)
        {
            var follow = _db.Follows.First(p => p.Id == id);
            if (follow != null)
                return follow;
            else
                return null;

        }
        public void Save(Follow follow)
        {
            if (follow.Id == 0)
            {
                _db.Follows.Add(follow);
                _db.SaveChanges();
            }

        }
        public void Update(Follow follow)
        {
            var Follow = _db.Follows.First(p => p.Id == follow.Id);
            if (Follow != null)
            {
                Follow.followedId = follow.followedId;
                Follow.followId = follow.followId;
                _db.SaveChanges();
            }
        }
    }
}
