namespace FileUpload_demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTerritory")]
    public partial class SalesTerritory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesTerritory()
        {
            SalesForces = new HashSet<SalesForce>();
        }

        public int SalesTerritoryId { get; set; }

        [StringLength(50)]
        public string SalesterritoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesForce> SalesForces { get; set; }
    }
}
