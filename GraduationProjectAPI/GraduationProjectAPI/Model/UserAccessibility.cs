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
    }
}
