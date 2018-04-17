namespace Dz_15
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanyModel : DbContext
    {
        public CompanyModel()
            : base("name=CompanyModel")
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Associate> Associates { get; set; }
    }
}