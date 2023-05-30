namespace GraduationProjectAPI.Model
{
    public class Test
    {
        public int Id { set; get; }
        public string test { set; get; }
        public int IdContent { set; get; }
        public virtual Content? Content { set; get; }
    }
}
