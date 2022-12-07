using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Films.Models;
using Films.Interfaces;

namespace Films.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmRepository _repository;

        public FilmsController(IFilmRepository context) => _repository = context;

        // GET: api/Films
        [HttpGet]
        public async Task<ActionResult<List<Film>>> GetFilm()
        {
            return await _repository.GetFilm();
        }

        // GET: api/Films/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilm(int id)
        {
            var film = await _repository.GetFilm(id);

            if (film == null)
            {
                return NotFound();
            }

            return film;
        }

        // PUT: api/Films/5
        [HttpPut("{id}")]
        public async Task<ActionResult<object>> PutFilm(int id, Film film)
        {
            var filmEx = await _repository.GetFilm(id);
            if (filmEx == null)
            {
                return BadRequest();
            }
            return await _repository.UpdateFilm(film);
        }

        // POST: api/Films
        [HttpPost]
        public async Task<ActionResult<object>> PostFilm(Film film)
        {
            return await _repository.AddFilm(film);
        }

        // DELETE: api/Films/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<object>> DeleteFilm(int id)
        {
            var film = await _repository.GetFilm(id);
            if (film == null)
            {
                return NotFound();
            }

            return await _repository.RemoveFilm(film);
        }
    }
}
