using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Common.Storage.Entities;

namespace SzkolenieTeczchniczne2.Cinema.Storage.Entities
{
    [Table("Movies", Schema = "Cinema")]
    public class Movie : BaseEntity
    {
        [MinLength(2)]
        [MaxLength(256)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Year { get; protected set; }
        public int SeanceTimeMinutes { get; protected set; }
        public string Description { get; protected set; }

        public virtual ICollection<Seance> Seances { get; set; }


    }
}
