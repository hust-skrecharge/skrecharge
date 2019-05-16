namespace SKR_User.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildingInfo")]
    public partial class BuildingInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistrictID { get; set; }

        public int? ChargingNum { get; set; }

        public int? OccupiedNum { get; set; }

        public int? DamagedNum { get; set; }

        public int? TotalNum { get; set; }

        public int? FreeNum { get; set; }

        public int? BuildingID { get; set; }
    }
}
