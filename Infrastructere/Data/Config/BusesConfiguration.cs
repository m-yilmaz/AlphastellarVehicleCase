using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructere.Data.Config
{
    public class BusesConfiguration : IEntityTypeConfiguration<Buss>
    {
        public void Configure(EntityTypeBuilder<Buss> builder)
        {
            builder.Property(x => x.ColorId).IsRequired();
        }
    }
}
