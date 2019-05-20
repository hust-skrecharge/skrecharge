namespace SKRUSER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logrfid")]
    public partial class logrfid
    {
        [Column("EPC ID")]
        [StringLength(50)]
        public string EPC_ID { get; set; }

        public long? count { get; set; }

        public int? wire { get; set; }

        [Key]
        public int ReadID { get; set; }
    }
}
