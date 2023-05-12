using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public partial class DbaptekiContext : DbContext
{
    public DbaptekiContext()
    {
    }

    public DbaptekiContext(DbContextOptions<DbaptekiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveSubstInDrug> ActiveSubstInDrugs { get; set; }

    public virtual DbSet<ActiveSubstance> ActiveSubstances { get; set; }

    public virtual DbSet<Availability> Availabilities { get; set; }

    public virtual DbSet<CategoriesOfDrug> CategoriesOfDrugs { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<DrugsAssortimentView> DrugsAssortimentViews { get; set; }

    public virtual DbSet<DrugsInfo> DrugsInfos { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<MedicalDevice> MedicalDevices { get; set; }

    public virtual DbSet<Pharmacist> Pharmacists { get; set; }

    public virtual DbSet<Pharmacy> Pharmacies { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Purchase1> Purchases1 { get; set; }

    public virtual DbSet<PurchaseInfo> PurchaseInfos { get; set; }

    public virtual DbSet<ScndTask> ScndTasks { get; set; }

    public virtual DbSet<ThrdTask> ThrdTasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HP76AG0\\SQLEXPRESS;Database=DBApteki;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveSubstInDrug>(entity =>
        {
            entity.HasKey(e => new { e.SubstInDrugId, e.DrugId }).HasName("PK_ACTIVESUBSTINDRUGS");

            entity.HasOne(d => d.Drug).WithMany(p => p.ActiveSubstInDrugs)
                .HasForeignKey(d => d.DrugId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ActiveSub__DrugI__47DBAE45");
        });

        modelBuilder.Entity<ActiveSubstance>(entity =>
        {
            entity.HasKey(e => e.SubstanceId).HasName("PK_ACTIVESUBSTANCE");

            entity.ToTable("ActiveSubstance");

            entity.Property(e => e.RouteIntoBloodstream)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.SubstanceName)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.ActiveSubstInDrug).WithMany(p => p.ActiveSubstances)
                .HasForeignKey(d => new { d.SubstInDrugId, d.DrugsId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ActiveSubstance__4AB81AF0");
        });

        modelBuilder.Entity<Availability>(entity =>
        {
            entity.HasKey(e => new { e.AssortimentId, e.Ogrn }).HasName("PK_AVAILABILITY");

            entity.ToTable("Availability");

            entity.Property(e => e.Ogrn).HasColumnName("OGRN");

            entity.HasOne(d => d.Assortiment).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.AssortimentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Availabil__Assor__534D60F1");

            entity.HasOne(d => d.OgrnNavigation).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.Ogrn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Availabili__OGRN__5441852A");
        });

        modelBuilder.Entity<CategoriesOfDrug>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK_CATEGORIESOFDRUGS");

            entity.Property(e => e.DrugsClassification)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.Drug).WithMany(p => p.CategoriesOfDrugs)
                .HasForeignKey(d => d.DrugId)
                .HasConstraintName("FK__Categorie__DrugI__4D94879B");
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity.HasKey(e => e.DrugId).HasName("PK_DRUGS");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("deleteDrugs");
                    tb.HasTrigger("insertDrug");
                });

            entity.Property(e => e.Manufacturer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.StorageRules).IsUnicode(false);

            entity.HasOne(d => d.Assortiment).WithMany(p => p.Drugs)
                .HasForeignKey(d => d.AssortimentId)
                .HasConstraintName("FK__Drugs__Assortime__44FF419A");
        });

        modelBuilder.Entity<DrugsAssortimentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DrugsAssortimentView");

            entity.Property(e => e.Manufacturer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Ogrn).HasColumnName("OGRN");
        });

        modelBuilder.Entity<DrugsInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DrugsInfo");

            entity.Property(e => e.DrugsClassification)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.RouteIntoBloodstream)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.SubstanceName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.AssortimentId).HasName("PK_GOODS");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("deleteGoods");
                    tb.HasTrigger("updateGoods");
                });
        });

        modelBuilder.Entity<MedicalDevice>(entity =>
        {
            entity.HasKey(e => e.DeviceId).HasName("PK_MEDICALDEVICES");

            entity.ToTable(tb => tb.HasTrigger("deleteMedicalDevice"));

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DeviceName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.DeviceType)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.Assortiment).WithMany(p => p.MedicalDevices)
                .HasForeignKey(d => d.AssortimentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MedicalDe__Assor__5070F446");
        });

        modelBuilder.Entity<Pharmacist>(entity =>
        {
            entity.HasKey(e => e.PharmacistId).HasName("PK_PHARMACISTS");

            entity.Property(e => e.Address)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Diploma)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Insurance)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Ogrn).HasColumnName("OGRN");
            entity.Property(e => e.Passport)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Patronymic)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Tin).HasColumnName("TIN");

            entity.HasOne(d => d.Buys).WithMany(p => p.Pharmacists)
                .HasForeignKey(d => d.BuysId)
                .HasConstraintName("FK__Pharmacis__BuysI__4222D4EF");

            entity.HasOne(d => d.OgrnNavigation).WithMany(p => p.Pharmacists)
                .HasForeignKey(d => d.Ogrn)
                .HasConstraintName("FK__Pharmacist__OGRN__412EB0B6");
        });

        modelBuilder.Entity<Pharmacy>(entity =>
        {
            entity.HasKey(e => e.Ogrn).HasName("PK_PHARMACIES");

            entity.ToTable(tb => tb.HasTrigger("deletePharmacies"));

            entity.HasIndex(e => e.Direction, "UQ__Pharmaci__2714D39174D1EBA3").IsUnique();

            entity.Property(e => e.Ogrn).HasColumnName("OGRN");
            entity.Property(e => e.Direction)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK_PURCHASE");

            entity.ToTable("Purchase", tb =>
                {
                    tb.HasTrigger("afterInsertPurchase");
                    tb.HasTrigger("insertPurchase");
                });

            entity.HasOne(d => d.Buy).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.BuyId)
                .HasConstraintName("FK__Purchase__BuyId__3E52440B");

            entity.HasOne(d => d.Good).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.GoodId)
                .HasConstraintName("FK__Purchase__GoodId__3D5E1FD2");
        });

        modelBuilder.Entity<Purchase1>(entity =>
        {
            entity.HasKey(e => e.BuysId).HasName("PK_PURCHASES");

            entity.ToTable("Purchases", tb => tb.HasTrigger("updatePurchases"));

            entity.Property(e => e.PurchaseTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PurchaseInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PurchaseInfo");

            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseTime).HasColumnType("datetime");
            entity.Property(e => e.Surname)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScndTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ScndTask");
        });

        modelBuilder.Entity<ThrdTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ThrdTask");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
