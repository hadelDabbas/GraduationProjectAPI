namespace GraduationProjectAPI.Model
{
    public class Post
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public byte[]? Image { set; get; }
        public DateTime? dateTime { set; get; }
        public int IdUser { set; get; }
        public virtual User? User { set; get; }
        public int IdType { set; get; }
        public virtual Type? Type { set; get; }
        public virtual ICollection<Group>? Group { set; get; }
        public virtual ICollection<Comment>? Comment { set; get; }
    }
}
