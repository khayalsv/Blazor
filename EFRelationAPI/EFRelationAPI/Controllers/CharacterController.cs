using EFRelationAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFRelationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly MyContext _myContext;

        public CharacterController(MyContext myContext)
        {
            _myContext = myContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get(int userId)
        {
            var characters = await _myContext.Characters.Where(x => x.UserId == userId).ToListAsync();

            return characters;
        }



        [HttpPost]
        public async Task<ActionResult<List<Character>>> Create(CreateCharacterDto request)
        {
            var user = await _myContext.Users.FindAsync(request.UserId);
            if (user == null)
                return NotFound();

            var newCharacter = new Character
            {
                Name = request.Name,
                RpgClass = request.RpgClass,
                User = user
            };

            _myContext.Characters.Add(newCharacter);
            await _myContext.SaveChangesAsync();

            return await Get(newCharacter.UserId);
        }
    }

}
