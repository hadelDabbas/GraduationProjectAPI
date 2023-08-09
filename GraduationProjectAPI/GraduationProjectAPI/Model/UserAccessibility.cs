namespace GraduationProjectAPI.Model
{
    public class UserAccessibility
    {
        public int Id { set; get; }
        public string AdminOn { set; get; }
        public int? IdAccessibility { set; get; }
        public virtual Accessibility? Accessibility { set; get; }
        public int? IdUser { set; get; }
        public virtual User? User { set; get; }
        public int? IdGroup { set; get; }
        public virtual Group? Group { set; get; }
        public int? IdLibrary { set; get; }
        public virtual Library? Library { set; get; }
    }
}
