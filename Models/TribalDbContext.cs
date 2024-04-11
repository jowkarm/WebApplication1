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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SQL9001.site4now.net;Initial Catalog=db_aa604d_tribaldb;Persist Security Info=True;User ID=db_aa604d_tribaldb_admin;Password=Ss5153@4648$;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.CaseId).HasName("PK__Case__6CAE524CCBAFAB21");

            entity.ToTable("Case");

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
            entity.HasKey(e => e.CheckInId).HasName("PK__CheckIn__E649768477F8E9C7");

            entity.ToTable("CheckIn");

            entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

            entity.HasOne(d => d.Profile).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileCheckIn");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__Profile__290C88E4D969E355");

            entity.ToTable("Profile");

            entity.HasIndex(e => e.CtcLinkId, "UQ_CtId").IsUnique();

            entity.Property(e => e.ClothingSize).HasMaxLength(5);
            entity.Property(e => e.TribeName).HasMaxLength(50);

            entity.HasOne(d => d.CtcLink).WithOne(p => p.Profile)
                .HasPrincipalKey<Student>(p => p.CtcLinkId)
                .HasForeignKey<Profile>(d => d.CtcLinkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profile_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B99F45FA0AC");

            entity.ToTable("Student");

            entity.HasIndex(e => e.CtcLinkId, "UQ_CtcLinkId").IsUnique();

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
