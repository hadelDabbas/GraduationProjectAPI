using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IUserPost
    {
        public UserPost GetUserPost(int id);
        public IQueryable<UserPost> GetUserPosts { get; }
        public void Save(UserPost userPost);
        public void Update(UserPost userPost);
        public void Delete(int id);
    }
}
