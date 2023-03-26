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

        public void Delete(int id)
        {
            var game = _db.Games.FirstOrDefault(p => p.Id == id);
            if (game != null)
            {
                _db.Games.Remove(game);
                _db.SaveChanges();
            }


        }
        public Game GetGame(int id)
        {
            var game = _db.Games.First(p => p.Id == id);
            if (game != null)
                return game;
            else
                return null;

        }
        public void Save(Game game)
        {
            if (game.Id == 0)
            {
                _db.Games.Add(game);
                _db.SaveChanges();
            }

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
    }
}
