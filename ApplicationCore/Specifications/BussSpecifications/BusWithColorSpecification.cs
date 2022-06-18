using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BussSpecifications
{
    public class BusWithColorSpecification : Specification<Bus>
    {
        public BusWithColorSpecification(string colorName)
        {
            Query.Include(x => x.Color)
                .Where(x => x.Color.ColorName.ToLower() == colorName.ToLower());
        }
    }
}
