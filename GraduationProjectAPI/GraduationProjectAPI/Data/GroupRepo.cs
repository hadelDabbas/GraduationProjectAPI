using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class GroupRepo:IGroup
    {
        private readonly GraduationProjectDbContext _db;
        public GroupRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Group> GetGroups => _db.Groups;

        public void Delete(int id)
        {
            var group = _db.Groups.FirstOrDefault(p => p.Id == id);
            if (group != null)
            {
                _db.Groups.Remove(group);
                _db.SaveChanges();
            }


        }
        public Group GetGroup(int id)
        {
            var group = _db.Groups.First(p => p.Id == id);
            if (group != null)
                return group;
            else
                return null;

        }
        public void Save(Group group)
        {
            if (group.Id == 0)
            {
                _db.Groups.Add(group);
                _db.SaveChanges();
            }

        }
        public void Update(Group group)
        {
            var Group = _db.Groups.First(p => p.Id == group.Id);
            if (Group != null)
            {
                Group.groupName = group.groupName;
                Group.Description = group.Description;
                Group.Image = group.Image;
                Group.IdType = group.IdType;
                Group.IdUser = group.IdUser;
                _db.SaveChanges();
            }
        }
    }
}
