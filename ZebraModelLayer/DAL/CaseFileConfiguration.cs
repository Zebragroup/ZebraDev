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
    public class CaseFileConfiguration : EntityTypeConfiguration<CaseFile>
    {
        public CaseFileConfiguration()
        {
            Property(c => c.AccountFileNumber).HasMaxLength(30).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_AccountFile") { IsUnique = true }));
            Property(c => c.ClientFile).HasMaxLength(50).IsRequired();
            Property(c => c.Department).HasMaxLength(50).IsRequired();
            Property(c => c.FileName).HasMaxLength(50).IsRequired();
            Property(c => c.FileNumber).HasMaxLength(50).IsRequired();
            Property(c => c.FileStatus).HasMaxLength(10).IsRequired();
            Property(c => c.FileType).HasMaxLength(20).IsRequired();
            Property(c => c.LeadProfessional).HasMaxLength(80).IsRequired();
            Property(c => c.OtherParty).HasMaxLength(50).IsRequired();
            Property(c => c.RecordNumber).HasMaxLength(20).IsRequired();
            Property(c => c.UpdatedUser).HasMaxLength(30).IsRequired();
            Property(c => c.UserDataEntry).HasMaxLength(30).IsRequired();
        }
    }
}
