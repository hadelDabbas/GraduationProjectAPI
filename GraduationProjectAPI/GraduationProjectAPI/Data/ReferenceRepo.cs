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

        public void Delete(Reference reference)
        {
            var Reference = _db.References.FirstOrDefault(p => p.Id == reference.Id);
            if (Reference != null)
            {
                var userRefre = _db.UserReferences.Where(p => p.IdReference == Reference.Id).ToList();
                var userAccess = _db.UserAccessibilities.Where(p => p.IdReference == Reference.Id).ToList();
                if(userRefre.Count != 0)
                {
                    _db.UserReferences.RemoveRange(userRefre);
                    _db.SaveChanges();
                }
                if(userAccess.Count != 0)
                {
                    foreach(UserAccessibility e in userAccess)
                    {
                        e.IdReference = 0;
                        _db.SaveChanges();
                    }
                }
                _db.References.Remove(reference);
                _db.SaveChanges();
            }


        }
        public Reference GetReference(int id)
        {
            var reference = _db.References.FirstOrDefault(p => p.Id == id);
            if (reference != null)
                return reference;
            else
                return null;

        }
        public bool Save(Reference reference)
        {
            if (reference.Id == 0)
            {
                if(!IsExisting(reference))
                {
                    _db.References.Add(reference);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
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
                Reference.IdAdmin = reference.IdAdmin;
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
        public List<RefrenceDto> GetAllRefrencesAdmins()
        {
            List<RefrenceDto> refrenceDtos = new List<RefrenceDto>();
            List<Reference> references = _db.References.Where(p => p.IdAdmin != 0).ToList();
          //  List<Content> cont = new List<Content>();
          //  List<Content> admincont = new List<Content>();
            List<User> admin = new List<User>();
            if(references != null)
            {
               foreach(Reference e in references)
               {
                    User u = _db.Users.FirstOrDefault(p => p.Id == e.IdAdmin);
                    RefrenceDto dto = new RefrenceDto();
                    if (!admin.Contains(u))
                    {
                    List<string> content = GetRefrenceByAdmin(u.Id);
                    dto.Admin = u;
                    dto.type = content;
                    
                        refrenceDtos.Add(dto);
                    }
                    admin.Add(dto.Admin);
               }
               if(refrenceDtos.Count!=0)
               {
                    return refrenceDtos;
               }
               else
               {
                    return null;
               }
            }
            else
            {
                return null;
            }
        }
        public List<string> GetRefrenceByAdmin(int IdUser)
        {
            var user = _db.Users.FirstOrDefault(p => p.Id == IdUser);
            if (user != null)
            {
                List<string> contents = new List<string>();
                List<Reference> Refcontents = _db.References.Where(p => p.IdContent != 0 && p.IdAdmin == IdUser).ToList();
                foreach (Reference e in Refcontents)
                {
                    Content c = _db.Contents.FirstOrDefault(p => p.Id == e.IdContent);
                    if (!contents.Contains(c.typeName))
                        contents.Add(c.typeName);
                }
                if (contents.Count != 0)
                {
                    return contents;
                }
                else return null;
            }
            else
            {
                return null;
            }
        }
        public bool IsExisting(Reference reference)
        {
            var data = _db.References.Any(p => p.referenceName == reference.referenceName);
            if (data != true)
            {
                return false;
            }
            else return true;
        }
    }
}
