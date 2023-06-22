namespace GraduationProjectAPI.Model
{
    public class Library
    {
        public int Id { set; get; }
        public string libraryName { set; get; }
        public string libraryAddress { set; get; }
    //    public virtual  ICollection<Buybook>? Buybook { set; get; }
        public virtual ICollection<BookLibrary>? BookLibrary { set; get; }
    }
}
