using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    [Table("CourseInstructors")]
    internal class CourseInstructor
    {
        #region Mapping by Convention
        //public int Instructor_id { get; set; }
        //public int Course_id { get; set; }
        //public string Evaluate { get; set; }

        #endregion

        #region Mapping by annotation
        [Key]
        public int InstructorId { get; set; }
        public Instructors Instructor { get; set; }
        [Key]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [Required]
        public string Evaluate { get; set; }

        #endregion

    }
}
