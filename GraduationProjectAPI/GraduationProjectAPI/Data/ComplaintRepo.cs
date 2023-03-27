using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class ComplaintRepo :IComplaint
    {
        private readonly GraduationProjectDbContext _db;
        public ComplaintRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Complaint> GetComplaints => _db.Complaints;

        public void Delete(int id)
        {
            var complaint = _db.Complaints.FirstOrDefault(p => p.Id == id);
            if (complaint != null)
            {
                _db.Complaints.Remove(complaint);
                _db.SaveChanges();
            }


        }
        public Complaint GetComplaint(int id)
        {
            var complaint = _db.Complaints.First(p => p.Id == id);
            if (complaint != null)
                return complaint;
            else
                return null;

        }
        public void Save(Complaint complaint)
        {
            if (complaint.Id == 0)
            {
                _db.Complaints.Add(complaint);
                _db.SaveChanges();
            }

        }
        public void Update(Complaint complaint)
        {
            var Complaint = _db.Complaints.First(p => p.Id == complaint.Id);
            if (Complaint != null)
            {
                Complaint.complaint = complaint.complaint;
                Complaint.IdUser = complaint.IdUser;
                _db.SaveChanges();
            }
        }
    }
}
