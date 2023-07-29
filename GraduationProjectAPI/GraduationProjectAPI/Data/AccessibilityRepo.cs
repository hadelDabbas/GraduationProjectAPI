using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class AccessibilityRepo : IAccessibility
    {
        private readonly GraduationProjectDbContext _db;
        public AccessibilityRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Accessibility> GetAccessibilties => _db.Accessibilities;

        public void Delete(int id)
        {
            var accessibility = _db.Accessibilities.FirstOrDefault(p => p.Id == id);
            if (accessibility != null)
            {
                _db.Accessibilities.Remove(accessibility);
                _db.SaveChanges();
            }


        }
        public Accessibility GetAccessibility(int id)
        {
            var accessibility = _db.Accessibilities.First(p => p.Id == id);
            if (accessibility != null)
                return accessibility;
            else
                return null;

        }
        public void Save(Accessibility accessibility)
        {
            if (accessibility.Id == 0)
            {

                _db.Accessibilities.Add(accessibility);
                _db.SaveChanges();

            }

        }
        public void Update(Accessibility accessibility)
        {
            var Accessibility = _db.Accessibilities.First(p => p.Id == accessibility.Id);
            if (Accessibility != null)
            {
                Accessibility.AccessibilityType = accessibility.AccessibilityType;
                _db.SaveChanges();
            }
        }
    }
}
