using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using ZebraModelLayer.Model;
using ZebraModelLayer.DAL;

namespace ZebraModelLayer.Model
{
    public class DevContext : DbContext
    {
        public DevContext()
            : base("ZebraDb")
        {

        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<CompanyDetails> CompanyDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new CompanyDetailsConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new CaseFileConfiguration());
            modelBuilder.Configurations.Add(new LeadProfessionalConfiguration());
        }
    }
}