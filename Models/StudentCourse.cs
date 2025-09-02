using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    internal class StudentCourse
    {
        #region Mapping by Nameing convention
        //public int Student_id { get; set; }
        //public int Course_id { get; set; }
        //public string Grade { get; set; }

        #endregion

        #region Mapping by data annotation
        [Key]
        public int Student_id { get; set; }
        [Key]
        public int Course_id { get; set; }
        [Required]
        public string Grade { get; set; }

        #endregion

    }
}
