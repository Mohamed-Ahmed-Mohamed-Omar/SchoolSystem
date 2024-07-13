using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;

namespace SchoolSystem.Infrustructure.Configurations
{
    public class Ins_SubjectConfigurations : IEntityTypeConfiguration<Ins_Subject>
    {
        public void Configure(EntityTypeBuilder<Ins_Subject> builder)
        {
            builder
                .HasKey(x => new { x.SubId, x.InsId });

            builder.HasOne(ds => ds.instructor)
                     .WithMany(d => d.Ins_Subjects)
                     .HasForeignKey(ds => ds.InsId);

            builder.HasOne(ds => ds.Subject)
                 .WithMany(d => d.Ins_Subjects)
                 .HasForeignKey(ds => ds.SubId);
        }
    }
}
