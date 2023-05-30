using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
   namespace GraduationProjectAPI.Data
   {
    public class ContentRepo : IContent
    {
        private readonly GraduationProjectDbContext _db;
        public ContentRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Content> GetContents => _db.Contents;

        public void Delete(int id)
        {
            var type = _db.Contents.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.Contents.Remove(type);
                _db.SaveChanges();
            }


        }
        public Content GetContent(int id)
        {
            var type = _db.Contents.FirstOrDefault(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;

        }
        public void Save(Content type)
        {
            var data = _db.Contents.Where(p => p.typeName == type.typeName);
            if (data != null)
            {
                _db.Contents.Add(type);
                _db.SaveChanges();
            }

        }
        public void Update(Content type)
        {
            var Type = _db.Contents.FirstOrDefault(p => p.Id == type.Id);
            if (Type != null)
            {
                Type.typeName = type.typeName;
                _db.SaveChanges();
            }
        }
    }
   }
