using EFCoreAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasKey(i => i.Department_id);
            builder.Property(i => i.Name).IsRequired().HasMaxLength(20);
        }
    }
}
