using Microsoft.EntityFrameworkCore;
using OBYS.Model.Entities;
using OBYS.Model.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYS.Model.Context
{
    public class OBYSContext : DbContext
    {
        public OBYSContext(DbContextOptions<OBYSContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LessonMap()); // LessonMap sınıfı içindeki değişiklikler tablo oluşturulurken dikkate alınıyor
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new TeacherMap());

            base.OnModelCreating(modelBuilder); // CoreMap sınıfı için çalışacak
        }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
