﻿using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class UserGroupRepo :IUserGroup
    {

        private readonly GraduationProjectDbContext _db;
        public UserGroupRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<UserGroup> GetUserGroups => _db.UserGroups;

        public void Delete(UserGroup userGroup)
        {
            var UserGroup = _db.UserGroups.FirstOrDefault(p => p.IdUser == userGroup.IdUser && p.IdGroup==userGroup.IdGroup);
            if (UserGroup != null)
            {
                _db.UserGroups.Remove(UserGroup);
                _db.SaveChanges();
            }


        }
        public UserGroup GetUserGroup(int id)
        {
            var userGroup = _db.UserGroups.First(p => p.Id == id);
            if (userGroup != null)
                return userGroup;
            else
                return null;

        }
        public void Save(UserGroup userGroup)
        {
            if (userGroup.Id == 0)
            {
                _db.UserGroups.Add(userGroup);
                _db.SaveChanges();
            }

        }
        public void Update(UserGroup userGroup)
        {
            var UserGroup = _db.UserGroups.First(p => p.Id == userGroup.Id);
            if (UserGroup != null)
            {
                UserGroup.IdGroup = userGroup.IdGroup;
                UserGroup.IdUser = userGroup.IdUser;
                _db.SaveChanges();
            }
        }
    }
}
