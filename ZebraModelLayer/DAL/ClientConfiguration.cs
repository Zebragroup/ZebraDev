using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZebraModelLayer.Model;

namespace ZebraModelLayer.DAL
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(c => c.AccountNumber).HasMaxLength(20).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_Account") { IsUnique = true }));
            Property(c => c.Amount).IsRequired().HasPrecision(18, 2);
            Property(c => c.ClientName).HasMaxLength(50).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_ClientName") { IsUnique = true }));
            Property(c => c.ClientNumber).HasMaxLength(20).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_ClientNumber") { IsUnique = true }));
            Property(c => c.ClientStatus).HasMaxLength(10).IsRequired();
            Property(c => c.ClientType).HasMaxLength(10).IsRequired();
            Property(c => c.Currency).HasMaxLength(5).IsRequired();
            Property(c => c.PaymentSchedule).HasMaxLength(5).IsRequired();
            Property(c => c.Retainer).HasMaxLength(10).IsRequired();
            Property(c => c.UpdateUser).HasMaxLength(25).IsOptional();
            Property(c => c.UserDateEntry).IsOptional();

        }

    }
}
