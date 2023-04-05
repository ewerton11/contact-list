using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecordsApi.Models;

namespace RecordsApi.Controller
{
    [ApiController]
    [Route("api/records")]
    public class RecordsItemsController : ControllerBase
    {
        private readonly RecordsContext _context;

        public RecordsItemsController(RecordsContext context)
        {
            _context = context;
        }

        // GET: api/records
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecordsItem>>> GetRecordsItems()
        {
            return await _context.RecordsItems
            .ToListAsync();
        }

        // GET: api/records/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecordsItem>> GetRecordsItem(int id)
        {
            var recordsItem = await _context.RecordsItems.FindAsync(id);

            if (recordsItem == null)
            {
                return NotFound();
            }

            return recordsItem;
        }

        // POST: api/records
        [HttpPost]
        public async Task<ActionResult<RecordsItem>> PostRecordsItem(RecordsItem recordsItem)
        {
            _context.RecordsItems.Add(recordsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecordsItem), new { id = recordsItem.Id }, recordsItem);
        }

        // DELETE: api/records/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecordsItem(int id)
        {
            var recordsItem = await _context.RecordsItems.FindAsync(id);

            if (recordsItem == null)
            {
                return NotFound();
            }

            _context.RecordsItems.Remove(recordsItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
