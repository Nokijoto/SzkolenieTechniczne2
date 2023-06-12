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
    [Table("Movies", Schema = "Cinema")]
    public class Movie : BaseEntity
    {
        protected Movie()
        { }
        public Movie(string name, int year, int sceneTime, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Year = year;
            SeanceTimeMinutes = sceneTime;
            Description = description;

        }
        [MinLength(2)]
        [MaxLength(256)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Year { get; protected set; }
        public int SeanceTimeMinutes { get; protected set; }
        public string Description { get; protected set; }

        public virtual ICollection<Seance> Seances { get; set; }

        public Seance GetSeanceByDateAndRoomId(DateTime date)
        {
            return Seances.SingleOrDefault(x => DateTime.Compare(x.Date, date) == 1);
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetSeanceTimeMinutes(int sceneTime)
        {
            SeanceTimeMinutes = sceneTime;
        }

        public void SetSeanceTime(int seanceTime)
        {
            throw new NotImplementedException();
        }
    }
}
