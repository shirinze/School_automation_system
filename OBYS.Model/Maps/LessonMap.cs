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
    public class LessonMap : CoreMap<Lesson>
    {
        public override void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.Property(x => x.LessonName).HasMaxLength(50).IsRequired(true);
        }
    }
}
