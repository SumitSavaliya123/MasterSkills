using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMaster.Model.DataModels
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options):base(options)
        {

        }

        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(u => u.Role)
                .HasDefaultValue("User");

                entity.Property(u => u.Status)
               .HasDefaultValue("Active");

               entity.Property(u => u.CreatedAt)
               .HasColumnName("created_at")
               .HasDefaultValueSql("getdate()");

            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skill");

                entity.Property(u => u.Status)
               .HasDefaultValue("Active");

                entity.Property(u => u.CreatedAt)
                .HasColumnName("created_at")
                .HasDefaultValueSql("getdate()");

            });


        }
       
    }
}
