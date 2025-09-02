using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    [Table("Department")]
    internal class Department
    {

        #region Mapping by Convention
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public int Instructor_id { get; set; }

        //public DateTime HiringDate { get; set; }
        #endregion

        #region Mapping by data annotation
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maximum length of name is 20 characters")]
        [MinLength(10, ErrorMessage = "Minimum length of name is 10 characters")]
        public string Name { get; set; }

        [Key]
        public int Instructor_id { get; set; }

        public DateTime HiringDate { get; set; }
        #endregion
    }
}
