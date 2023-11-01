using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLabWebAPI.Data;
using MusicLabWebAPI.Models;

namespace MusicLabWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
            
        {
            var songs = _context.Songs.ToList();
            return StatusCode(200, songs);
        }

        // GET: api/Songs/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var song =_context.Songs.Find(id);
            if(song == null)
            {
                return NotFound();
            }
            return StatusCode(200, song);
        }

        // POST: api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        // PUT: api/Songs/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Song song)
            
        {
            _context.Songs.Update(song);
            _context.SaveChanges();
            return StatusCode(200, song);
                
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            _context.Songs.Remove(song);
            _context.SaveChanges();

            return NoContent();

        }
            
            

            


            
        
    }
}
