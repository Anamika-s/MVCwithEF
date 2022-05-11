using MVCWithEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEF.Context
{
    public class AppDbContext  : DbContext
    {
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        // Fluent Api

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Entity<Student>().ToTable("tblStudent");

            modelBuilder.Entity<Student>()
                 .HasKey(x => x.RollNo);

            modelBuilder.Entity<Student>()
                  .Property(p => p.Name)
                  .HasColumnName("StudnetName")
                  .HasColumnOrder(2)
                  .HasColumnType("varchar")
                  .IsRequired()
                  .HasMaxLength(30);

            modelBuilder.Entity<Student>()
          .HasRequired<Batch>(s=>s.Batch)
          .WithMany(g => g.Students)
          .HasForeignKey<int>(s => s.batchId);


        }
    }
}