using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.CarSpecifications
{
    public class CarsSpecification : Specification<Car>
    {
        public CarsSpecification()
        {
            Query.Include(x => x.Color);
        }
        public CarsSpecification(int id)
        {
            Query.Include(x => x.Color).Where(x => x.Id == id);
        }
    }
}
