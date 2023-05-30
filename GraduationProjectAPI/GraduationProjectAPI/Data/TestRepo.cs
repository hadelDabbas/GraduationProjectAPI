using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class TestRepo:ITest
    {
        private readonly GraduationProjectDbContext _db;
        public TestRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Test> GetTests => _db.Tests;

        public void Delete(int id)
        {
            var test = _db.Tests.FirstOrDefault(p => p.Id == id);
            if (test != null)
            {
                _db.Tests.Remove(test);
                _db.SaveChanges();
            }


        }
        public Test GetTest(int id)
        {
            var test = _db.Tests.First(p => p.Id == id);
            if (test != null)
                return test;
            else
                return null;

        }
        public void Save(Test test)
        {
            if (test.Id == 0)
            {
                _db.Tests.Add(test);
                _db.SaveChanges();
            }

        }
        public void Update(Test test)
        {
            var Test = _db.Tests.First(p => p.Id == test.Id);
            if (Test != null)
            {
                Test.IdContent = test.IdContent;
                Test.test = test.test;
                _db.SaveChanges();
            }
        }
    }
}
