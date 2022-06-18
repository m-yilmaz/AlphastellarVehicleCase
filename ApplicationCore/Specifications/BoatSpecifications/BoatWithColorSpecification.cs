using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BoatSpecifications
{
    public class BoatWithColorSpecification : Specification<Boat>
    {
        public BoatWithColorSpecification(string colorName)
        {
            Query.Include(x => x.Color)
                .Where(x => x.Color.ColorName.ToLower() == colorName.ToLower());
        }
    }
}
