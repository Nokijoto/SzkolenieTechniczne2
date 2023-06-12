using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Service.Query.Dtos
{
    public class MovieDto
    {
        public MovieDto(string name, Guid id)
        {
            this.Name = name;
            this.Id = id;

        }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public MovieDto() { }


    }
}
