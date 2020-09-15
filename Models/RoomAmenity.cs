﻿using AsyncInn.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASyncInn.Models
{
    public class RoomAmenity
    {
        public long AmenityId { get; set; }
        public long RoomId { get; set; }

        [ForeignKey(nameof(AmenityId))]
        public Amenity Amenity { get; set; }

        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; }
    }
}
