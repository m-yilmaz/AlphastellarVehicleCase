using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.CarSpecifications
{
    public class CarsWithColorSpecification : Specification<Car>
    {
        public CarsWithColorSpecification(string colorName)
        {
            Query.Include(x => x.Color)
                .Where(x => x.Color.ColorName.ToLower() == colorName.ToLower());
        }
    }
}
