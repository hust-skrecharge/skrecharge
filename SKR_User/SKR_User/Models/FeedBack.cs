namespace SKR_User.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedBack")]
    public partial class FeedBack
    {
        public int FeedbackID { get; set; }

        public int? Damagetype { get; set; }

        public int PileId { get; set; }

        [StringLength(50)]
        public string EngineerReback { get; set; }

        public int? Occupiedtype { get; set; }
    }
}
