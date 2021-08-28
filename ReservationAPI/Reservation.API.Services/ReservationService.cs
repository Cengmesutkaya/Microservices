using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationById(int Id)
        {
            return new ReservationDTO()
            {
                Id = Id,
                CheckingDate = DateTime.Now.Date.AddDays(7),
                CheckOutDate = DateTime.Now.Date.AddDays(17),
                Amount = (new Random()).Next(100)
            } ;
        }
    }
}
