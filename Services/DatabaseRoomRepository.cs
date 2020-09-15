using ASyncInn.Data;
using ASyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASyncInn.Services
{
    public class DatabaseRoomRepository : IRoomsRepository
    {
        private readonly AsyncInnDbContext _context;
        public DatabaseRoomRepository(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetOneByIdAsync(long id)
        {
            var hotel = await _context.Rooms.FindAsync(id);
            return hotel;
        }

        public async Task<bool> UpdateAsync(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RoomExistsAsync(room.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }
        public async Task CreateAsync(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> DeleteAsync(long id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return null;
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return room;
        }

        private async Task<bool> RoomExistsAsync(long id)
        {
            return await _context.Rooms.AnyAsync(e => e.Id == id);
        }

        public Task DeleteAmenityFromRoom(long roomId, long amenityId)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAmenityToRoom(long roomId, long amenityId)
        {
            throw new System.NotImplementedException();
        }
    }
}
