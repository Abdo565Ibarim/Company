using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.GO2.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.GO2.DAL.Data.Configurations
{
    public class DepratmentConfigurations : IEntityTypeConfiguration<Depratment>
    {
        public void Configure(EntityTypeBuilder<Depratment> builder)
        {
            builder.Property(D => D.Id ).UseIdentityColumn(10  ,10 );
        }
    }
}
