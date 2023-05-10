namespace GraduationProjectAPI.Model
{
    public class Group
    {
        public int Id { set; get; }
        public string groupName { set; get; }
        public int IdPost { set; get; }
        public virtual Post? Post { set; get; }
        public int IdUser { set; get; }
        public virtual User? User { set; get; }
        public int IdType { set; get; }
        public virtual Type? Type { set; get; }
        //image
    }
}
