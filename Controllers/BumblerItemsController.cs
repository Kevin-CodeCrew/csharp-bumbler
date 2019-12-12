using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BumblerApi.Models;

namespace BumblerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BumblerItemsController : ControllerBase
    {
        private readonly BumblerContext _context;

        public BumblerItemsController(BumblerContext context)
        {
            _context = context;
        }

        // GET: api/BumblerItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BumblerItem>>> GetBumblerItems()
        {
            return await _context.BumblerItems.ToListAsync();
        }

        // GET: api/BumblerItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BumblerItem>> GetBumblerItem(long id)
        {
            var bumblerItem = await _context.BumblerItems.FindAsync(id);

            if (bumblerItem == null)
            {
                return NotFound();
            }

            return bumblerItem;
        }

        // PUT: api/BumblerItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBumblerItem(long id, BumblerItem bumblerItem)
        {
            if (id != bumblerItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bumblerItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BumblerItemExists(id))
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

        // POST: api/BumblerItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<BumblerItem>> PostBumblerItem(BumblerItem bumblerItem)
        {
            _context.BumblerItems.Add(bumblerItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBumblerItem", new { id = bumblerItem.Id }, bumblerItem);
        }

        // DELETE: api/BumblerItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BumblerItem>> DeleteBumblerItem(long id)
        {
            var bumblerItem = await _context.BumblerItems.FindAsync(id);
            if (bumblerItem == null)
            {
                return NotFound();
            }

            _context.BumblerItems.Remove(bumblerItem);
            await _context.SaveChangesAsync();

            return bumblerItem;
        }

        private bool BumblerItemExists(long id)
        {
            return _context.BumblerItems.Any(e => e.Id == id);
        }
    }
}
