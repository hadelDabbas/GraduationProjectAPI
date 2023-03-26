using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class TypeRepo:IType
    {
        private readonly GraduationProjectDbContext _db;
        public TypeRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Model.Type> GetTypes => _db.Types;

        public void Delete(int id)
        {
            var type = _db.Types.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.Types.Remove(type);
                _db.SaveChanges();
            }


        }
        public Model.Type GetType(int id)
        {
            var type = _db.Types.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;

        }
        public void Save(Model.Type type)
        {
            if (type.Id == 0)
            {
                _db.Types.Add(type);
                _db.SaveChanges();
            }

        }
        public void Update(Model.Type type)
        {
            var Type = _db.Types.First(p => p.Id == type.Id);
            if (Type != null)
            {
                Type.typeName = type.typeName;
                _db.SaveChanges();
            }
        }
    }
}
