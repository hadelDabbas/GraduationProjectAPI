using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IComplaint
    {
        public Complaint GetComplaint(int id);
        public IQueryable<Complaint> GetComplaints { get; }
        public void Save(Complaint complaint);
        public void Update(Complaint complaint);
        public void Delete(Complaint complaint);
        public List<Complaint> UserComplaint(int IdUser);
    }
}
