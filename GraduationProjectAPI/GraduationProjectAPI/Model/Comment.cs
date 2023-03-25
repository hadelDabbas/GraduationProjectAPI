namespace GraduationProjectAPI.Model
{
    public class Comment
    {
        public int Id { set; get; }
        public string comment { set; get; }
        public int IdPost { set; get; }
        public virtual Post? Post { set; get; }
    }
}
