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
    public class ClientesController : ControllerBase
    {
        private readonly LojaContext _context;

        public ClientesController(LojaContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Clientes.Include(c => c.Consultor).Include(c => c.Telefones);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public IActionResult GetCliente([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = _context.Clientes.Include(c => c.Consultor).Include(c => c.Telefones).FirstOrDefault(i => i.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente([FromRoute] int id, [FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            foreach (var telefone in cliente.Telefones)
            {
                if (telefone.Id > 0)
                    _context.Entry(telefone).State = EntityState.Modified;
                else
                    _context.Entry(telefone).State = EntityState.Added;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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

        // POST: api/Clientes
        [HttpPost]
        public async Task<IActionResult> PostCliente([FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = _context.Clientes.Include(c => c.Consultor).Include(c => c.Telefones).FirstOrDefault(i => i.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            //foreach (Telefone t in cliente.Telefones)
            //{
            //    _context.Telefone.Remove(t);
            //}

            _context.Telefone.RemoveRange(cliente.Telefones);
            
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return Ok(cliente);
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}