using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class PostRepo:IPost
    {
        private readonly GraduationProjectDbContext _db;
        public PostRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Post> GetPosts => _db.Posts;

        public void Delete(int id)
        {
            var post = _db.Posts.FirstOrDefault(p => p.Id == id);
            if (post != null)
            {
                _db.Posts.Remove(post);
                _db.SaveChanges();
            }


        }
        public Post GetPost(int id)
        {
            var post = _db.Posts.First(p => p.Id == id);
            if (post != null)
                return post;
            else
                return null;

        }
        public void Save(Post post)
        {
            if (post.Id == 0)
            {
                _db.Posts.Add(post);
                _db.SaveChanges();
            }

        }
        public void Update(Post post)
        {
            var Post = _db.Posts.First(p => p.Id == post.Id);
            if (Post != null)
            {
                Post.dateTime = post.dateTime;
                Post.Description = post.Description;
                Post.Image = post.Image;
                Post.IdContent = post.IdContent;
                Post.IdUser = post.IdUser;
                post.IdGroup = post.IdGroup;
                _db.SaveChanges();
            }
        }
    }
}
