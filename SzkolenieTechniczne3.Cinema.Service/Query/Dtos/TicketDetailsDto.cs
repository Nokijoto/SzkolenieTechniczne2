using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Dtos
{
    public class TicketDetailsDTO
    {
        public TicketDetailsDTO(string email, int peopleCount, Guid id, DateTime purchesDate)
        {
            Email = email;
            PeopleCount = peopleCount;
            Id = id;
            PurchesDate = purchesDate;
        }

        public string Email { get; }

        public Guid Id { get; }

        public int PeopleCount { get; }

        public DateTime PurchesDate { get; }
    }
}
