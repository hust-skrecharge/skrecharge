namespace SKRUSER.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PileInfo")]
    public partial class PileInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistrictID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PileID { get; set; }

        public int? OccupiedType { get; set; }

        public int? ChargingType { get; set; }

        public int? DamagedType { get; set; }

        public int? UsageTimes { get; set; }

        public int? BuildingID { get; set; }
    }
}
