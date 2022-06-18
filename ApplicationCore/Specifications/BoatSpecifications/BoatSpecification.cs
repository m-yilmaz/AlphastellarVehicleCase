using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BoatSpecifications
{
    public class BoatSpecification : Specification<Boat>
    {
        public BoatSpecification()
        {
            Query.Include(x => x.Color);
        }

        public BoatSpecification(int id) : this()
        {
            Query.Where(x => x.Id == id);
        }
    }
}
