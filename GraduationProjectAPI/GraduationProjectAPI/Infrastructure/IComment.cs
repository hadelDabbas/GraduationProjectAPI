using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IComment
    {
        public Comment GetComment(int id);
        public IQueryable<Comment> GetComments { get; }
        public void Save(Comment comment);
        public void Update(Comment comment);
        public void Delete(int id);
    }
}
