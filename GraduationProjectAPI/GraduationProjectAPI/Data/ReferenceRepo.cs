using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
using GraduationProjectAPI.Dto;
namespace GraduationProjectAPI.Data
{
    public class ReferenceRepo:IReference
    {
        private readonly GraduationProjectDbContext _db;
        public ReferenceRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Reference> GetReferences => _db.References;

        public void Delete(int id)
        {
            var reference = _db.References.FirstOrDefault(p => p.Id == id);
            if (reference != null)
            {
                _db.References.Remove(reference);
                _db.SaveChanges();
            }


        }
        public Reference GetReference(int id)
        {
            var reference = _db.References.First(p => p.Id == id);
            if (reference != null)
                return reference;
            else
                return null;

        }
        public void Save(Reference reference)
        {
            if (reference.Id == 0)
            {
                _db.References.Add(reference);
                _db.SaveChanges();
            }

        }
        public void Update(Reference reference)
        {
            var Reference = _db.References.First(p => p.Id == reference.Id);
            if (Reference != null)
            {
                Reference.dateTime = reference.dateTime;
                Reference.IdContent = reference.IdContent;
                Reference.Link = reference.Link;
                Reference.referenceName = reference.referenceName;
                _db.SaveChanges();
            }
        }
        public List<string> GetRefrencesContent()
        {
            List<string> contents = new List<string>();
            List<Reference> Refcontents = _db.References.Where(p => p.IdContent != 0).ToList();
            foreach(Reference e in Refcontents)
            {
                Content c = _db.Contents.FirstOrDefault(p => p.Id == e.IdContent);
                if( !contents.Contains(c.typeName))
                contents.Add(c.typeName);
            }
            if (contents.Count != 0)
            {
                return contents;
            }
            else return null;
        }
        public List<Reference> GetRefrenceLink(int IdContenet)
        {
            List<Reference> references = _db.References.Where(p => p.IdContent == IdContenet).ToList();
            if(references.Count != 0)
            {
                return references;
            }
            return null;
        }
    }
}
