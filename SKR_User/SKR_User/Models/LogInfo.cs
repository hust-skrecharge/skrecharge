namespace SKR_User.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogInfo")]
    public partial class LogInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogID { get; set; }

        public int? EPC { get; set; }

        public int? UserID { get; set; }

        public int? UserType { get; set; }

        public DateTime? InTIME { get; set; }

        public DateTime? OutTime { get; set; }

        public TimeSpan? UsageTime { get; set; }

        public double? PaySum { get; set; }

        public int? DistrictID { get; set; }

        public int? PileID { get; set; }

        public int? UserFrequence { get; set; }

        public int? OrderID { get; set; }

        public double? PriceRate { get; set; }

        public int? BuildingID { get; set; }
    }
}
