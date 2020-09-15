using System.Collections.Generic;

namespace ASyncInn.Models
{
    public class Room
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Layout { get; set; }
        public List<RoomAmenity> RoomAmenities { get; set; }

    }
}
