namespace FileUpload_demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesForce")]
    public partial class SalesForce
    {
        public int SalesForceId { get; set; }

        [StringLength(50)]
        public string SalesForceName { get; set; }

        [StringLength(250)]
        public string Pic { get; set; }

        public DateTime? JoinDate { get; set; }

        public int? SalesTerritoryId { get; set; }

        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
