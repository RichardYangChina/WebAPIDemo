using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIDemo.Models
{
    public partial class MyDemoContext : DbContext
    {
        public virtual DbSet<TUser> TUser { get; set; }

        // Unable to generate entity type for table 'dbo.T_CART'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DLC5CG745137FLH\SQL2014;Database=MyDemo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("T_USER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mygift)
                    .HasColumnName("MYGIFT")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Passcode)
                    .HasColumnName("PASSCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Sex).HasColumnName("SEX");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(50);
            });
        }
    }
}