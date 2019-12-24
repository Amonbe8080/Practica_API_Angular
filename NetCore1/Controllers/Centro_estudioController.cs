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
    public class Centro_estudioController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public Centro_estudioController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Centro_estudio
        [HttpGet]
        public IEnumerable<Centro_estudio> GetCentro_estudio()
        {
            return _context.Centro_estudio;
        }

        // GET: api/Centro_estudio/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCentro_estudio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var centro_estudio = await _context.Centro_estudio.FindAsync(id);

            if (centro_estudio == null)
            {
                return NotFound();
            }

            return Ok(centro_estudio);
        }

        // PUT: api/Centro_estudio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCentro_estudio([FromRoute] int id, [FromBody] Centro_estudio centro_estudio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != centro_estudio.codigo_centro)
            {
                return BadRequest();
            }

            _context.Entry(centro_estudio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Centro_estudioExists(id))
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

        // POST: api/Centro_estudio
        [HttpPost]
        public async Task<IActionResult> PostCentro_estudio([FromBody] Centro_estudio centro_estudio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Centro_estudio.Add(centro_estudio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCentro_estudio", new { id = centro_estudio.codigo_centro }, centro_estudio);
        }

        // DELETE: api/Centro_estudio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCentro_estudio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var centro_estudio = await _context.Centro_estudio.FindAsync(id);
            if (centro_estudio == null)
            {
                return NotFound();
            }

            _context.Centro_estudio.Remove(centro_estudio);
            await _context.SaveChangesAsync();

            return Ok(centro_estudio);
        }

        private bool Centro_estudioExists(int id)
        {
            return _context.Centro_estudio.Any(e => e.codigo_centro == id);
        }
    }
}