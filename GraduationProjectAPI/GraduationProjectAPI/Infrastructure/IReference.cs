using GraduationProjectAPI.Model;
using GraduationProjectAPI.Dto;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IReference
    {
        public Reference GetReference(int id);
        public IQueryable<Reference> GetReferences { get; }
        public void Save(Reference reference);
        public void Update(Reference reference);
        public void Delete(int id);
        public List<string> GetRefrencesContent();
        public List<Reference> GetRefrenceLink(int IdContenet);
    }
}
