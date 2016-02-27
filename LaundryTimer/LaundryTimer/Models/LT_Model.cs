namespace LaundryTimer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LT_Model : DbContext
    {
        public LT_Model()
            : base("name=LT_Model")
        {
        }

        public virtual DbSet<Appliance> Appliances { get; set; }
        public virtual DbSet<ApplianceType> ApplianceTypes { get; set; }
        public virtual DbSet<Master> Masters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
