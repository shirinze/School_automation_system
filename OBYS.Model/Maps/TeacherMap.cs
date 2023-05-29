﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBYS.Core.Map;
using OBYS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Model.Maps
{
    public class TeacherMap : CoreMap<Teacher>
    {
        public override void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.TeacherName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.TeacherSurname).HasMaxLength(50).IsRequired(true);
        }
    }
}
