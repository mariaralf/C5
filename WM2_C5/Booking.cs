using System;
using System.Collections.Generic;

namespace WM2_C5
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int? BookingUserId { get; set; }
        public int? BookingHotelId { get; set; }
        public DateTime? BookingDate { get; set; }

        public virtual Hotel? BookingHotel { get; set; }
        public virtual User? BookingUser { get; set; }
    }
}
