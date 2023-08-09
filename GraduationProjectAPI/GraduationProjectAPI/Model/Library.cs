namespace GraduationProjectAPI.Model
{
    public class Library
    {
        public int Id { set; get; }
        public string libraryName { set; get; }
        public string libraryAddress { set; get; }
       // public int IdAdmin { set; get; }
        public bool IsDeleted { set; get; }
    //    public virtual  ICollection<Buybook>? Buybook { set; get; }
        public virtual ICollection<BookLibrary>? BookLibrary { set; get; }
        public virtual ICollection<UserAccessibility>? UserAccessibility { set; get; }
    }
}
