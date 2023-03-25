namespace GraduationProjectAPI.Model
{
    public class Buybook
    {
        // book-user
        public int Id { set; get; }
        public double Price { set; get; }
        public string? Address { set; get; }
        public int IdUser { set; get; }
        public virtual User? User { set; get; }
        public int IdLibrary { set; get; }
        public virtual Library? Library { set; get; }
    }
}
