using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class GameService : IGameService
    {
        private readonly MyContext _context;
        private readonly NavigationManager _navigationManager;

        public GameService(MyContext context, NavigationManager navigationManager = null)
        {
            _context = context;
            _context.Database.EnsureCreated();
            _navigationManager = navigationManager;
        }

        public List<Game> Games { get; set; } = new List<Game>();

        public async Task CreateGame(Game game)
        {
            _context.Games.Add(game);

            await _context.SaveChangesAsync();

            _navigationManager.NavigateTo("/");

        }

        public async Task DeleteGame(int id)
        {
            var dbGame = await _context.Games.FindAsync(id);
            if (dbGame == null)
                throw new Exception("No game here. :/");

            _context.Games.Remove(dbGame);

            await _context.SaveChangesAsync();

            _navigationManager.NavigateTo("/");
        }

        public async Task<Game> GetSingleGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                throw new Exception("No game here. :/");
            return game;

        }

        public async Task UpdateGame(Game game,int id)
        {
            var dbGame = await _context.Games.FindAsync(id);
            if(dbGame==null)
                throw new Exception("No game here. :/");

            dbGame.Name = game.Name;
            dbGame.Developer = game.Developer;
            dbGame.Release = game.Release;

            await _context.SaveChangesAsync();
         
            _navigationManager.NavigateTo("/");
        }

        public async Task LoadGames()
        {
            Games = await _context.Games.ToListAsync();
        }

    }
}
