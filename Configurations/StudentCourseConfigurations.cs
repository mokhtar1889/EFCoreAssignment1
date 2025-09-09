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
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(s => s.StudentId);
            builder.HasKey(s => s.CourseId);
            builder.Property(s => s.Grade).IsRequired();
        }
    }
}
