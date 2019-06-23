using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIP2.Models;

namespace APIP2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultoresController : ControllerBase
    {
        private readonly LojaContext _context;

        public ConsultoresController(LojaContext context)
        {
            _context = context;
        }

        // GET: api/Consultores
        [HttpGet]
        public IEnumerable<Consultor> GetConsultores()
        {
            return _context.Consultores;
        }

        // GET: api/Consultores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsultor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var consultor = await _context.Consultores.FindAsync(id);

            if (consultor == null)
            {
                return NotFound();
            }

            return Ok(consultor);
        }

        // PUT: api/Consultores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultor([FromRoute] int id, [FromBody] Consultor consultor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != consultor.Id)
            {
                return BadRequest();
            }

            _context.Entry(consultor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultorExists(id))
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

        // POST: api/Consultores
        [HttpPost]
        public async Task<IActionResult> PostConsultor([FromBody] Consultor consultor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Consultores.Add(consultor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultor", new { id = consultor.Id }, consultor);
        }

        // DELETE: api/Consultores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var consultor = await _context.Consultores.FindAsync(id);
            if (consultor == null)
            {
                return NotFound();
            }

            _context.Consultores.Remove(consultor);
            await _context.SaveChangesAsync();

            return Ok(consultor);
        }

        private bool ConsultorExists(int id)
        {
            return _context.Consultores.Any(e => e.Id == id);
        }
    }
}