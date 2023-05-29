using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBYS.Core.Map;
using OBYS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Model.Maps
{
    public class StudentMap : CoreMap<Student>
    {
        public override void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.StudentName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.StudentSurname).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Gender).HasMaxLength(50).IsRequired(true);
        }
    }
}
