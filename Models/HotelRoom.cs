namespace ASyncInn.Models
{
    public class HotelRoom
    {
        public long HotelId { get; set; }
        public long RoomNumber { get; set; }
        public long RoomId { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }

    }
}
