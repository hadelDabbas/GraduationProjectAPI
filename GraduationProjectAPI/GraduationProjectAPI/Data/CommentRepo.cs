using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class CommentRepo :IComment
    {
        private readonly GraduationProjectDbContext _db;
        public CommentRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Comment> GetComments => _db.Comments;

        public void Delete(int id)
        {
            var commet = _db.Comments.FirstOrDefault(p => p.Id == id);
            if (commet != null)
            {
                _db.Comments.Remove(commet);
                _db.SaveChanges();
            }


        }
        public Comment GetComment(int id)
        {
            var comment = _db.Comments.First(p => p.Id == id);
            if (comment != null)
                return comment;
            else
                return null;

        }
        public void Save(Comment comment)
        {
            if (comment.Id == 0)
            {
                _db.Comments.Add(comment);
                _db.SaveChanges();
            }

        }
        public void Update(Comment comment)
        {
            var Comment = _db.Comments.First(p => p.Id == comment.Id);
            if (Comment != null)
            {
                Comment.comment = comment.comment;
                Comment.IdPost = comment.IdPost;
                _db.SaveChanges();
            }
        }
    }
}
