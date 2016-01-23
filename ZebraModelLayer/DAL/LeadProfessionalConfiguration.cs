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
    public class LeadProfessionalConfiguration : EntityTypeConfiguration<LeadProfessional>
    {
        public LeadProfessionalConfiguration()
        {
            Property(l => l.LeadCode).HasMaxLength(10).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("AK_LeadCode") { IsUnique = true }));
            Property(l => l.LeadProfessionalName).HasMaxLength(50).IsRequired();

        }

    }
}
