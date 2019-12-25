using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore1.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public AlumnosController(AplicationDBContext context)
        {
            _context = context;

        }

        // GET: api/Alumnos/5521 (Buscar con un Inner Join)
        [HttpGet("{id}")]
        public IActionResult GetIdAlumno([FromForm] int id)
        {
            var res = from a in _context.Alumnos
                      join c in _context.Carreras on a.codigo_carrera equals c.codigo_carrera
                      join ce in _context.Centro_estudio on a.codigo_centro equals ce.codigo_centro
                      where a.id == id && a.estado != "Suspendido"
                      select new
                      {
                          id = a.id,
                          nombre = a.nombre,
                          apellido = a.apellido,
                          edad = a.edad,
                          genero = a.genero,
                          fecha_ingreso = a.fecha_ingreso,
                          codigo_carrera = c.codigo_carrera,
                          nombre_carrera = c.nombre_carrera,
                          nombre_centro_estudio = ce.nombre_centro_estudio
                      };

            // Devuelve NoContent en caso de que: Existe pero este suspendido
            // Devuelve Ok en caso de que: Exista y este activo.
            if (res.Count() == 0)
            {
                return NoContent();
            }
            else
            {
                return Ok(res);
            }
        }

        // GET: api/Alumnos (Listar con un Inner Join)
        [HttpGet]
        public IActionResult GetAlumnos()
        {
            var test = (from a in _context.Alumnos
                        join c in _context.Carreras on a.codigo_carrera equals c.codigo_carrera
                        join ce in _context.Centro_estudio on a.codigo_centro equals ce.codigo_centro
                        where a.estado != "Suspendido"
                        select new
                        {
                            id = a.id,
                            nombre = a.nombre,
                            apellido = a.apellido,
                            edad = a.edad,
                            genero = a.genero,
                            fecha_ingreso = a.fecha_ingreso,
                            codigo_carrera = c.codigo_carrera,
                            nombre_carrera = c.nombre_carrera,
                            nombre_centro_estudio = ce.nombre_centro_estudio
                        });
            return Ok(test);
        }

        // PUT: api/Alumnos/5 (Actualizar)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnos([FromForm] Alumnos alumnos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(alumnos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }
        }

        // POST: api/Alumnos (Añadir Usuario, incluye creación de carpeta y subida de fotos)
        [HttpPost]
        public async Task<IActionResult> PostAlumnos([FromForm] Alumnos alumnos, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (AlumnosExists(alumnos.id))
            {
                return BadRequest(alumnos.id);
            }
            // Genera la ruta final en donde se debe guardar la imagen
            string direc = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/UserFiles/" + alumnos.id + "/");

            // Valida si existe, en caso de que no. La creara
            if (!Directory.Exists(direc))
            {
                Directory.CreateDirectory(direc);
            }

            var path = Path.Combine(direc + "/" + file.FileName);

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                // Pasa la imagen a la carpeta del usuario respectivo
                file.CopyTo(stream);
            }
            _context.Alumnos.Add(alumnos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumnos", new { id = alumnos.id }, alumnos);
        }

        // DELETE: api/Alumnos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnos([FromForm] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumnos = await _context.Alumnos.FindAsync(id);

            if (alumnos == null)
            {
                return NotFound();
            }
            string direc = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/UserFiles/" + alumnos.id + "/");
            Directory.Delete(direc, true);

            // No usa un DELETE, se usa un UPDATE con un campo especial en la base de datos
            alumnos.estado = "Suspendido";
            _context.Alumnos.Update(alumnos);
            await _context.SaveChangesAsync();

            return Ok(alumnos);
        }

        private bool AlumnosExists(int id)
        {
            return _context.Alumnos.Any(e => e.id == id);
        }
    }
}