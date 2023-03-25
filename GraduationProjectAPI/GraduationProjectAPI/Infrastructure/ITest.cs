using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface ITest
    {
        public Test GetTest(int id);
        public IQueryable<Test> GetTests { get; }
        public void Save(Test test);
        public void Update(Test test);
        public void Delete(int id);
    }
}
