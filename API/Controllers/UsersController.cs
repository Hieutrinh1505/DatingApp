using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() // simple iteration over a collection of a specified type
        {
            return await _context.Users.ToListAsync();// Async

        }
        //api/users/index. Get data by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id) // simple iteration over a collection of a specified type
        {
            return await _context.Users.FindAsync(id);

        }
    }
}
