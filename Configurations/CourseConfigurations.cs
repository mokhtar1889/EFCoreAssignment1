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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.HasKey(c => c.Top_id);
            builder.Property(c => c.Duration).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(20).IsRequired();
        }
    }
}
