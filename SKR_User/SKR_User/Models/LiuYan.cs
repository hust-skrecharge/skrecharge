namespace SKR_User.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LiuYan")]
    public partial class LiuYan
    {
        public int LiuYanID { get; set; }

        public int UserId { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
