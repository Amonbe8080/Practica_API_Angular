using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public CarrerasController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Carreras
        [HttpGet]
        public IEnumerable<Carreras> GetCarreras()
        {
            return _context.Carreras;
        }

        // GET: api/Carreras/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarreras([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carreras = await _context.Carreras.FindAsync(id);

            if (carreras == null)
            {
                return NotFound();
            }

            return Ok(carreras);
        }

        // PUT: api/Carreras/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarreras([FromRoute] int id, [FromBody] Carreras carreras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carreras.codigo_carrera)
            {
                return BadRequest();
            }

            _context.Entry(carreras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrerasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Carreras
        [HttpPost]
        public async Task<IActionResult> PostCarreras([FromBody] Carreras carreras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Carreras.Add(carreras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarreras", new { id = carreras.codigo_carrera }, carreras);
        }

        // DELETE: api/Carreras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarreras([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carreras = await _context.Carreras.FindAsync(id);
            if (carreras == null)
            {
                return NotFound();
            }

            _context.Carreras.Remove(carreras);
            await _context.SaveChangesAsync();

            return Ok(carreras);
        }

        private bool CarrerasExists(int id)
        {
            return _context.Carreras.Any(e => e.codigo_carrera == id);
        }
    }
}