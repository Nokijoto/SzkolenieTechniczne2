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
    [Table("Seances", Schema = "Cinema")]
    public class Seance : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }
        public Guid MovieId { get; set; }
        public int NumberOfTickets { get; set; }

        [Required]
        public Movie Movie { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }

        public Seance(DateTime seanceDate, Guid movieId)
        {
            Id = Guid.NewGuid();
            Date = seanceDate;
            MovieId = movieId;
        }

        public void Add(Ticket ticket)
        {
           Tickets.Add(ticket);
        }
    }
}