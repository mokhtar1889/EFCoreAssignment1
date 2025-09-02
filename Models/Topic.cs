using System.ComponentModel.DataAnnotations;


namespace EFCoreAssignment.Models
{
    internal class Topic
    {
        #region Mapping by name Convention
        //public int Id { get; set; }
        //public string Name { get; set; }

        #endregion

        #region Mapping by data annotation
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        #endregion
    }
}
