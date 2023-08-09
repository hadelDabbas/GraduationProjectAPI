using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Data
{
    public class GameRepo:IGame
    {
        private readonly GraduationProjectDbContext _db;
        public GameRepo(GraduationProjectDbContext db)
        {
            _db = db;
        }
        public IQueryable<Game> GetGames => _db.Games;

        public void Delete(Game Game)
        {
            var game = _db.Games.FirstOrDefault(p => p.Id == Game.Id);
            if (game != null)
            {
                var gameuser = _db.GameUsers.Where(p => p.IdGame == game.Id).ToList();
                if(gameuser.Count != 0)
                {
                    _db.GameUsers.RemoveRange(gameuser);
                    _db.SaveChanges();
                }
                _db.Games.Remove(game);
                _db.SaveChanges();
            }


        }
        public Game GetGame(int id)
        {
            var game = _db.Games.FirstOrDefault(p => p.Id == id);
            if (game != null)
                return game;
            else
                return null;

        }
        public bool Save(Game game)
        {
            if (game.Id == 0)
            {
                if (!IsExisting(game))
                {
                    _db.Games.Add(game);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public void Update(Game game)
        {
            var Game = _db.Games.First(p => p.Id == game.Id);
            if (Game != null)
            {
                Game.GameLevel = game.GameLevel;
                Game.GameName= game.GameName;
                _db.SaveChanges();
            }
        }
        public bool IsExisting(Game game)
        {
            var data = _db.Games.Any(p => p.GameName == game.GameName);
            if (data != true)
            {
                return false;
            }
            else return false;
        }
    }
}
