using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public DateTime? CheckingDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public decimal Amount { get; set; }

    }
}
