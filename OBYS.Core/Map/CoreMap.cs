using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBYS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Core.Map
{
    // T herhangi bir dosya olabilir dedik
    // where T : CoreEntity ==> T ifadesinin CoreEntity veya bu sınıftan miras almış olmasını istedik
    // CoreMap sınıfı iile oluşacak tablonun design kısmıyla ilgili kontrolleri yazarız
    // Fluent api kullandık
    public abstract class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreateDate).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
        }
    }
}
