using System;
using System.Collections.Generic;

namespace WM2_C5
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public int? UserRole { get; set; }

        public virtual Role? UserRoleNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
