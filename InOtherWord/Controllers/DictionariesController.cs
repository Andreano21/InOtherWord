#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InOtherWord.Data;
using InOtherWord.Models;

namespace InOtherWord.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionariesController : ControllerBase
    {
        private readonly DataContext _context;

        public DictionariesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Dictionaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dictionary>>> GetDictionaries()
        {
            return await _context.Dictionaries.ToListAsync();
        }

        // GET: api/Dictionaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dictionary>> GetDictionary(int id)
        {
            var dictionary = await _context.Dictionaries.FindAsync(id);

            if (dictionary == null)
            {
                return NotFound();
            }

            return dictionary;
        }

        // PUT: api/Dictionaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDictionary(int id, Dictionary dictionary)
        {
            if (id != dictionary.Id)
            {
                return BadRequest();
            }

            _context.Entry(dictionary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DictionaryExists(id))
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

        // POST: api/Dictionaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dictionary>> PostDictionary(Dictionary dictionary)
        {
            _context.Dictionaries.Add(dictionary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDictionary", new { id = dictionary.Id }, dictionary);
        }

        // DELETE: api/Dictionaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDictionary(int id)
        {
            var dictionary = await _context.Dictionaries.FindAsync(id);
            if (dictionary == null)
            {
                return NotFound();
            }

            _context.Dictionaries.Remove(dictionary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DictionaryExists(int id)
        {
            return _context.Dictionaries.Any(e => e.Id == id);
        }
    }
}
