using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
namespace GraduationProjectAPI.Data
{
    public class BuybookRepo :IBuybook
    {
        private readonly GraduationProjectDbContext _db;
        public BuybookRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Buybook> GetBuybooks => _db.Buybooks;

        public void Delete(int id)
        {
            var buyBook = _db.Buybooks.FirstOrDefault(p => p.Id == id);
            if (buyBook != null)
            {
                _db.Buybooks.Remove(buyBook);
                _db.SaveChanges();
            }


        }
        public Buybook GetBuybook(int id)
        {
            var buyBook = _db.Buybooks.First(p => p.Id == id);
            if (buyBook != null)
                return buyBook;
            else
                return null;

        }
        public void Save(Buybook buyBook)
        {
            if (buyBook.Id == 0)
            {
                _db.Buybooks.Add(buyBook);
                _db.SaveChanges();
            }

        }
        public void Update(Buybook buyBook)
        {
            var BuyBook = _db.Buybooks.First(p => p.Id == buyBook.Id);
            if (BuyBook != null)
            {
                BuyBook.Address = buyBook.Address;
                BuyBook.IdLibrary = buyBook.IdLibrary;
                BuyBook.IdUser = buyBook.IdUser;
                BuyBook.Price = buyBook.Price;
                _db.SaveChanges();
            }
        }
    }
}
