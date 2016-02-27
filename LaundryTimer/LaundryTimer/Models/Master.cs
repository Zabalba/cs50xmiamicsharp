namespace LaundryTimer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master")]
    public partial class Master
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string UserName { get; set; }

        [Required]
        [StringLength(150)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(150)]
        public string UserHash { get; set; }

        public bool Active { get; set; }

        public bool ResetPass { get; set; }
    }
}
