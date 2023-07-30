using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Dto;
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
                BuyBook.IdBookLibrary = buyBook.IdBookLibrary;
                BuyBook.IdUser = buyBook.IdUser;
                BuyBook.Price = buyBook.Price;
                _db.SaveChanges();
            }
        }
        public List<BuyBookDto> GetAllBuys(int IdLibrary)
        {
            var library = _db.Libraries.FirstOrDefault(p => p.Id == IdLibrary);
            List<Buybook> buybooks=new List<Buybook>();
            List<BuyBookDto> dto = new List<BuyBookDto>();
           List< int >idUser =new List<int>(0);
            if (library != null)
            {
                List<BookLibrary> bookLibraries = _db.BookLibraries.Where(p => p.IdLibrary == IdLibrary).ToList();
                foreach(BookLibrary e in bookLibraries)
                {
                   List<Buybook>  b = _db.Buybooks.Where(p => p.IdBookLibrary == e.Id).ToList();
                    if(b.Count != 0)
                    {
                        buybooks.AddRange(b);
                    }
                }
                if(buybooks.Count != 0)
                foreach(Buybook e in buybooks)
                {
                    List<Buybook> usersbuy = _db.Buybooks.Where(p => p.IdUser == e.IdUser && !idUser.Contains(p.IdUser)).ToList();
                        if (usersbuy.Count != 0)
                        {
                            BuyBookDto buyBookDto = new BuyBookDto();
                            buyBookDto.user = _db.Users.FirstOrDefault(p => p.Id == e.IdUser);
                            buyBookDto.userBooks = usersbuy;
                            if( !dto.Contains(buyBookDto))
                            dto.Add(buyBookDto);
                             idUser.Add(buyBookDto.user.Id);
                        }
                }
                if(dto.Count != 0)
                {
                    return dto;
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
