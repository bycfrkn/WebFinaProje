using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace services.ModelsS;

public partial class MvcDbYemekSitesiContext : DbContext
{
    public MvcDbYemekSitesiContext()
    {
    }

    public MvcDbYemekSitesiContext(DbContextOptions<MvcDbYemekSitesiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDbCorba> TblDbCorbas { get; set; }

    public virtual DbSet<TblDbIcecekler> TblDbIceceklers { get; set; }

    public virtual DbSet<TblDbIzgara> TblDbIzgaras { get; set; }

    public virtual DbSet<TblDbKullanici> TblDbKullanicis { get; set; }

    public virtual DbSet<TblDbSalatum> TblDbSalata { get; set; }

    public virtual DbSet<TblDbTatli> TblDbTatlis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=FURKQN\\SQLEXPRESS;Initial Catalog= MvcDbYemekSitesi;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblDbCorba>(entity =>
        {
            entity.HasKey(e => e.CorbaId);

            entity.ToTable("TblDbCorba");

            entity.Property(e => e.CorbaAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CorbaResim).IsUnicode(false);
        });

        modelBuilder.Entity<TblDbIcecekler>(entity =>
        {
            entity.HasKey(e => e.IcecekId);

            entity.ToTable("TblDbIcecekler");

            entity.Property(e => e.IcecekAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IcecekResim).IsUnicode(false);
        });

        modelBuilder.Entity<TblDbIzgara>(entity =>
        {
            entity.HasKey(e => e.IzgaraId);

            entity.ToTable("TblDbIzgara");

            entity.Property(e => e.IzgaraAd)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IzgaraResim).IsUnicode(false);
        });

        modelBuilder.Entity<TblDbKullanici>(entity =>
        {
            entity.HasKey(e => e.KullaniciId);

            entity.ToTable("TblDbKullanici");

            entity.Property(e => e.KullaniciId).HasColumnName("kullaniciId");
            entity.Property(e => e.KullaniciAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciSifre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciSoyad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kullaniciSoyad");
        });

        modelBuilder.Entity<TblDbSalatum>(entity =>
        {
            entity.HasKey(e => e.SalataId);

            entity.Property(e => e.SalataAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalataResim).IsUnicode(false);
        });

        modelBuilder.Entity<TblDbTatli>(entity =>
        {
            entity.HasKey(e => e.TatliId);

            entity.ToTable("TblDbTatli");

            entity.Property(e => e.TatliAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TatliAD");
            entity.Property(e => e.TatliResim)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
