using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
using GraduationProjectAPI.Dto;
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
        public List<Content> GetTestContent()
        {
            List<Test> tests = _db.Tests.ToList();
            List<Content> contents = new List<Content>();
            foreach(Test e in tests)
            {
                Content c = _db.Contents.FirstOrDefault(p => p.Id == e.IdContent);
                if( !contents.Contains(c))
                {
                    contents.Add(c);
                }  
            }
            if (contents.Count != 0)
            {
                return contents;
            }
            else 
            {
                return null;
            }
        }
        public List<TestDto> GetTestsForContent(int IdContent)
        {
            Content c = _db.Contents.FirstOrDefault(p => p.Id == IdContent);
            List<Test> tests = new List<Test>();
            List<TestDto> dto = new List<TestDto>();
            if (c != null)
            {
                 tests = _db.Tests.Where(p => p.IdContent == c.Id).ToList();
            }
            foreach(Test e in tests)
            {
                List<Answer> answers = _db.Answers.Where(p => p.IdTest == e.Id).ToList();
                if(answers.Count != 0)
                {
                    TestDto testDto = new TestDto();
                    testDto.Test = e;
                    testDto.answers = answers;
                    if( !dto.Contains(testDto))
                    {
                        dto.Add(testDto);
                    }
                }
            }
            if(dto.Count !=0)
            {
                return dto;
            }
            else
            {
                return null;
            }
            //if(tests.Count != 0)
            //{
            //    return tests;
            //}
            //else
            //{
            //    return null;
            //}
        }
        public int GetTestId(string test)
        {
            var Test = _db.Tests.FirstOrDefault(p => p.test == test);
            if(Test != null)
            {
                return Test.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
