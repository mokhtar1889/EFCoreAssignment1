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
    internal class CourseInstructorConfigurations : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(e => e.CourseId);
            builder.HasKey(e => e.InstructorId);
            builder.Property(e => e.Evaluate).IsRequired();
        }
    }
}
