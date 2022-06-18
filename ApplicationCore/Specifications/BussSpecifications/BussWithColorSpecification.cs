using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.BussSpecifications
{
    public class BussWithColorSpecification : Specification<Buss>
    {
        public BussWithColorSpecification(string colorName)
        {
            Query.Include(x => x.Color)
                .Where(x => x.Color.ColorName.ToLower() == colorName.ToLower());
        }
    }
}
