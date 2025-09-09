using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    [Table("Course")]
    internal class Course
    {

        #region Mapping by Convention
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public string Duration { get; set; }

        //public string Description { get; set; }

        //public int Top_id { get; set; }

        #endregion

        #region Mapping by Data Annotation
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maximum length of name is 20 characters")]
        [MinLength(10, ErrorMessage = "Minimum length of name is 10 characters")]
        public string Name { get; set; }

        [Required]
        public string Duration { get; set; }

        public string Description { get; set; }

        public int TopicId{ get; set; }

        public Topic Topic { get; set; }

        #endregion



    }
}
