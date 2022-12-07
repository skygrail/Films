using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Films.Models;

namespace Films.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersFilmsController : ControllerBase
    {
        private readonly FilmsDbContext _context;

        public UsersFilmsController(FilmsDbContext context)
        {
            _context = context;
        }

        // GET: api/UsersFilms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersFilms>>> GetUsersFilms()
        {
            return await _context.UsersFilms.ToListAsync();
        }

        // GET: api/UsersFilms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsersFilms>> GetUsersFilms(int id)
        {
            var usersFilms = await _context.UsersFilms.FindAsync(id);

            if (usersFilms == null)
            {
                return NotFound();
            }

            return usersFilms;
        }

        //// PUT: api/UsersFilms/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUsersFilms(int id, UsersFilms usersFilms)
        //{
        //    if (id != usersFilms.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(usersFilms).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UsersFilmsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/UsersFilms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.

        [HttpPost]
        public async Task<ActionResult<UsersFilms>> PostUsersFilms(UsersFilms usersFilms)
        {
            _context.UsersFilms.Add(usersFilms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsersFilms", new { id = usersFilms.ID }, usersFilms);
        }

        // DELETE: api/UsersFilms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UsersFilms>> DeleteUsersFilms(int id)
        {
            var usersFilms = await _context.UsersFilms.FindAsync(id);
            if (usersFilms == null)
            {
                return NotFound();
            }

            _context.UsersFilms.Remove(usersFilms);
            await _context.SaveChangesAsync();

            return usersFilms;
        }

        private bool UsersFilmsExists(int id)
        {
            return _context.UsersFilms.Any(e => e.ID == id);
        }
    }
}
