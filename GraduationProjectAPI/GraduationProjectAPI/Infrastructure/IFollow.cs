using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IFollow
    {
        public Follow GetFollow(int id);
        public IQueryable<Follow> GetFollows { get; }
        public void Save(Follow follow);
        public void Update(Follow follow);
        public void Delete(int id);
    }
}
