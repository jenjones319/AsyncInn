using AsyncInn.Models;
using ASyncInn.Data;
using ASyncInn.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASyncInn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        private readonly AsyncInnDbContext _context;
        private readonly IAmenityRepository repository;

        public AmenitiesController(AsyncInnDbContext context, IAmenityRepository repository)
        {
            _context = context;
            this.repository = repository;
        }

        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenity>>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amenity>> GetAmenity(long id)
        {
            var amenity = await _context.Amenities.FindAsync(id);

            if (amenity == null)
            {
                return NotFound();
            }

            return amenity;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenity(long id, Amenity amenity)
        {
            if (id != amenity.Id)
            {
                return BadRequest();
            }

            _context.Entry(amenity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenityExists(id))
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

        // POST: api/Amenities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Amenity>> PostAmenity(Amenity amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmenity", new { id = amenity.Id }, amenity);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Amenity>> DeleteAmenity(long id)
        {
            var amenity = await _context.Amenities.FindAsync(id);
            if (amenity == null)
            {
                return NotFound();
            }

            _context.Amenities.Remove(amenity);
            await _context.SaveChangesAsync();

            return amenity;
        }

        private bool AmenityExists(long id)
        {
            return _context.Amenities.Any(e => e.Id == id);
        }

        [HttpPost("{roomId}/Amenity/{amenityId}")]
        public async Task<ActionResult<Amenity>> AddAmenityToRoom(long roomId, long amenityId)
        {
            await repository.AddAmenityToRoom(roomId, amenityId);
            return CreatedAtAction(nameof(AddAmenityToRoom), new { roomId, amenityId }, null);
        }
        [HttpDelete("{roomId}/Amenity/{amenityId}")]
        public async Task<ActionResult<Amenity>> DeleteAmenityFromRoom(long roomId, long amenityId)
        {
            await repository.DeleteAmenityFromRoom(roomId, amenityId);
            return Ok();
        }
    }
}
