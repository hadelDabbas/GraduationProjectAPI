using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IComments
    {
        public Comments GetComment(int id);
        public IQueryable<Comments> GetComments { get; }
        public void Save(Comments comment);
        public void Update(Comments comment);
        public void Delete(int id);
        public List<Comments> PostComments(int IdPost);
    }
}
