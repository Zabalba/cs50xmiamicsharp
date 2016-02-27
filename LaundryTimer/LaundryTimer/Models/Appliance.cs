namespace LaundryTimer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appliance
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int ApplianceTypeID { get; set; }

        [StringLength(100)]
        public string ApplianceName { get; set; }

        [StringLength(200)]
        public string ApplianceUserNote { get; set; }

        public int ApplianceCycleLength { get; set; }

        public bool ApplianceActive { get; set; }

        public bool ApplianceCycleActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ApplianceCycleEnd { get; set; }

        public bool NotifyOnCompletion { get; set; }
    }
}
