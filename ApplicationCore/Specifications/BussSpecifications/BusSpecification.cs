using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BussSpecifications
{
    public class BusSpecification : Specification<Bus>
    {
        public BusSpecification()
        {
            Query.Include(x => x.Color);
        }
        public BusSpecification(int id) : this()
        {
            Query.Where(x => x.Id == id);
        }
    }
}
