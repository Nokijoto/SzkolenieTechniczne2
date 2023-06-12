using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Common.Storage.Entities;

namespace SzkolenieTechniczne2.Cinema.Storage.Entities
{
    [Table("Tickets", Schema = "Cinema")]
    public class Ticket : BaseEntity
    {
        protected Ticket() { }

        public Ticket(string email, int peopleCount)
        {
            Id = Guid.NewGuid();
            Email = email;

            PeopleCount = peopleCount;
        }
        [MinLength(2)]
        [MaxLength(128)]
        [Required]
        public string Email { get; set; }

        [MinLength(9)]
        [MaxLength(64)]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public int PeopleCount { get; set; }
        public Guid SeanceId { get; set; }
        public Seance Seance { get; set; }
    }
}
