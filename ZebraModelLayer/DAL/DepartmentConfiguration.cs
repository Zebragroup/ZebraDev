using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZebraModelLayer.Model;

namespace ZebraModelLayer.DAL
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            Property(d => d.RecordNumber).HasMaxLength(50).IsRequired();
            Property(d => d.TeamIncome).HasMaxLength(25).IsRequired();
            Property(d => d.DepartmentCostCenter).HasMaxLength(25).IsRequired();
        }

    }
}
