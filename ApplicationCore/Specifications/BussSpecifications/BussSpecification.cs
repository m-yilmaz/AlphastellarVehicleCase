using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BussSpecifications
{
    public class BussSpecification : Specification<Buss>
    {
        public BussSpecification()
        {
            Query.Include(x => x.Color);
        }
        public BussSpecification(int id)
        {
            Query.Include(x => x.Color).Where(x => x.Id == id);
        }
    }
}
