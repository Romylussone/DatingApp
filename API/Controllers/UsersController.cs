using API.Data;
using API.Enities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")] // api/users
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> getUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}