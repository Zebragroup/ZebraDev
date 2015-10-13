using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using ZebraModelLayer.Model;
using ZebraModelLayer.Model;

namespace ZebraModelLayer.Model
{
    public class DevContext : DbContext
    {
        public DevContext()
            : base("ZebraConnection")
        {

        }


        public DbSet<Client> Client { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add (new ClientConfiguration());
        }
    }
}