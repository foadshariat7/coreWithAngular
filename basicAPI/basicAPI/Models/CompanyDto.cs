using basicAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI.Models
{
    public class CompanyDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Founded { get; set; }

        public ICollection<TechnologyDto> Technologies { get; set; } = new List<TechnologyDto>();
    }
}
