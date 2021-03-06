using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Staff.Entities.Mapping
{
    public class RegisterForOvertimeMap : EntityTypeConfiguration<RegisterForOvertime>
    {
        public RegisterForOvertimeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
           // this.Property(t => t.Name).HasMaxLength(150);
                        this.Property(t => t.Note).HasMaxLength(300);


            // Table & Column Mappings
            this.ToTable("Staff_RegisterForOvertime");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUserId).HasColumnName("ModifiedUserId");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.AssignedUserId).HasColumnName("AssignedUserId");
            this.Property(t => t.Code).HasColumnName("Code");

            this.Property(t => t.StaffId).HasColumnName("StaffId");
            this.Property(t => t.DayOvertime).HasColumnName("DayOvertime");
            this.Property(t => t.StartHour).HasColumnName("StartHour");
            this.Property(t => t.EndHour).HasColumnName("EndHour");
            this.Property(t => t.Note).HasColumnName("Note");

        }
    }
}
