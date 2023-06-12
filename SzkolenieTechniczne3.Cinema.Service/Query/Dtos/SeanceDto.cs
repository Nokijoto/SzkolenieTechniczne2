using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Dtos
{
    public class SeanceDto
    {
        public SeanceDto(Guid id, DateTime date)
        {
            Date = date;
            Id = id;
        }

        public Guid Id { get; }

        public DateTime? Date { get; }
    }   
}
