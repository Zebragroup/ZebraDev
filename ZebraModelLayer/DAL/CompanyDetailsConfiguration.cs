using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZebraModelLayer.Model;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace ZebraModelLayer.DAL
{
    public class CompanyDetailsConfiguration : EntityTypeConfiguration<CompanyDetails>
    {
        public CompanyDetailsConfiguration()
        {
            HasKey(c => c.CompanyId);
            Property(c => c.CompanyName).HasMaxLength(150).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_CompanyName") { IsUnique = true }));
            Property(c => c.Telephone).HasMaxLength(15).IsRequired();
            Property(c => c.Address).HasMaxLength(80).IsRequired();
            Property(c => c.RecordNumber).HasMaxLength(20).IsOptional();
            Property(c => c.Website).HasMaxLength(50).IsOptional();
            Property(c => c.Email).HasMaxLength(50).IsOptional();
            Property(c => c.City).HasMaxLength(50).IsOptional();
            Property(c => c.Fax).HasMaxLength(20).IsOptional();
            Property(c => c.CompanyMoto).HasMaxLength(30).IsOptional();
        }
    }
}
