using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    internal class Instructors
    {


        #region Mapping by Convention
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Salary { get; set; }
        //public decimal Bonus { get; set; }
        //public string Address { get; set; }
        //public decimal HourRate { get; set; }
        //public int Department_id { get; set; }

        #endregion

        #region Mapping by data annotation
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Maximum length of name is 20 characters")]
        [MinLength(10, ErrorMessage = "Minimum length of name is 10 characters")]
        public string Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        [Key]
        public int Department_id { get; set; }

        #endregion

    }
}
