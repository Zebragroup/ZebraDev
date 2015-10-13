using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using ZebraModelLayer.Model;
namespace ZebraModelLayer.Model
{
    public class ClientConfiguration:EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(c => c.ClientNumber).HasMaxLength(50).IsRequired();
            Property(c => c.ClientName).HasMaxLength(100).IsRequired();
            Property(c => c.ClientStatus).HasMaxLength(50).IsOptional();
            Property(c => c.PaymentSchedule).HasMaxLength(100).IsOptional();
            Property(c => c.UserDateEntry).IsRequired();
            Property(c => c.Retainer).HasMaxLength(80).IsOptional();
            Property(c => c.Currency).HasMaxLength(10).IsOptional();
            Property(c => c.Amount).IsRequired();
            Property(c => c.UpdateUser).HasMaxLength(80).IsOptional();
            Property(c => c.ClientType ).HasMaxLength(80).IsOptional ();
        }

    }
}