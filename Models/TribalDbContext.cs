using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class TribalDbContext : DbContext
{
    public TribalDbContext()
    {
    }

    public TribalDbContext(DbContextOptions<TribalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CheckIn> CheckIns { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Case__3214EC07C83024E8");

            entity.ToTable("Case");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateClosed).HasColumnType("datetime");
            entity.Property(e => e.DateOpened).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FollowUpDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(50);

            entity.HasOne(d => d.Profile).WithMany(p => p.Cases)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileCase");
        });

        modelBuilder.Entity<CheckIn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckIn__3214EC07D97205A7");

            entity.ToTable("CheckIn");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

            entity.HasOne(d => d.Profile).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileCheckIn");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Profile__3214EC07B4A9F523");

            entity.ToTable("Profile");

            entity.HasIndex(e => e.StudentId, "UQ_StudentId").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClothingSize).HasMaxLength(5);
            entity.Property(e => e.TribeName).HasMaxLength(50);

            entity.HasOne(d => d.Student).WithOne(p => p.Profile)
                .HasForeignKey<Profile>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profile_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC07A58B3489");

            entity.ToTable("Student");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
