namespace GraduationProjectAPI.Model
{
    public class Test
    {
        public int Id { set; get; }
        public string test { set; get; }
        public int IdType { set; get; }
        public virtual Type? Type { set; get; }
    }
}
