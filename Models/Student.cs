using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Models
{
    [Table("Student")]
    internal class Student
    {
        #region Mapping by naming Convention
        //public int Id { get; set; }
        //public int FName { get; set; }
        //public int LName { get; set; }
        //public int Address { get; set; }
        //public int Age { get; set; }
        //public int Dep_id { get; set; }

        #endregion

        #region Mapping by data annotation
        [Key]
        public int Id { get; set; }
        [Required]
        public int FName { get; set; }
        [Required]
        public int LName { get; set; }
        public int Address { get; set; }
        [Range(20,30)]
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        #endregion
    }
}
