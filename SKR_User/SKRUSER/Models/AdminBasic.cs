namespace SKRUSER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminBasic")]
    public partial class AdminBasic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }

        [Required]
        [StringLength(10)]
        public string AdminName { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        public int? SuperAdmin { get; set; }

        [StringLength(50)]
        public string AdminImage { get; set; }
    }
}
