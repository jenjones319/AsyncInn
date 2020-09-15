using ASyncInn.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASyncInn.Services
{
    public interface IRoomsRepository
    {
        Task<IEnumerable<Room>> GetAllAsync();
        Task<Room> GetOneByIdAsync(long id);
        Task CreateAsync(Room room);
        Task<Room> DeleteAsync(long id);
        Task<bool> UpdateAsync(Room room);
        Task DeleteAmenityFromRoom(long roomId, long amenityId);
        Task AddAmenityToRoom(long roomId, long amenityId);
    }
}
