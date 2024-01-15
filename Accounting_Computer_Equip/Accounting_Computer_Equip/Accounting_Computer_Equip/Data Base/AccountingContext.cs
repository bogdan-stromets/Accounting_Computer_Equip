using System;
using System.Collections.Generic;
using Accounting_Computer_Equip.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounting_Computer_Equip;

public partial class AccountingContext : DbContext
{
    public AccountingContext() {}

    public AccountingContext(DbContextOptions<AccountingContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Computer> Computers { get; set; }

    public virtual DbSet<NetworkDevice> NetworkDevices { get; set; }

    public virtual DbSet<OfficeEquipment> OfficeEquipments { get; set; }

    public virtual DbSet<PcСomponent> PcСomponents { get; set; }

    public virtual DbSet<PeripheralDevice> PeripheralDevices { get; set; }

    public virtual DbSet<Supply> Supplies { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Accounting;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Computer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("computers_pkey");

            entity.ToTable("computers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsWorking).HasColumnName("is_working");
            entity.Property(e => e.MacAdress)
                .HasMaxLength(17)
                .HasColumnName("mac_adress");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.PcType)
                .HasMaxLength(50)
                .HasColumnName("pc_type");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Computers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("computers_user_id_fkey");
        });

        modelBuilder.Entity<NetworkDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("network_devices_pkey");

            entity.ToTable("network_devices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsWorking).HasColumnName("is_working");
            entity.Property(e => e.MacAdress)
                .HasMaxLength(17)
                .HasColumnName("mac_adress");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.TypeOf)
                .HasMaxLength(50)
                .HasColumnName("type_of");
        });

        modelBuilder.Entity<OfficeEquipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("office_equipment_pkey");

            entity.ToTable("office_equipment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsWorking).HasColumnName("is_working");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.TypeOf)
                .HasMaxLength(50)
                .HasColumnName("type_of");
        });

        modelBuilder.Entity<PcСomponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pc_Сomponents_pkey");

            entity.ToTable("pc_Сomponents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComputerId).HasColumnName("computer_id");
            entity.Property(e => e.IsWorking).HasColumnName("is_working");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.TypeOf)
                .HasMaxLength(50)
                .HasColumnName("type_of");

            entity.HasOne(d => d.Computer).WithMany(p => p.PcСomponents)
                .HasForeignKey(d => d.ComputerId)
                .HasConstraintName("pc_Сomponents_computer_id_fkey");
        });

        modelBuilder.Entity<PeripheralDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("peripheral_devices_pkey");

            entity.ToTable("peripheral_devices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConnectedTo).HasColumnName("connected_to");
            entity.Property(e => e.IsWorking).HasColumnName("is_working");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.TypeOf)
                .HasMaxLength(50)
                .HasColumnName("type_of");

            entity.HasOne(d => d.ConnectedToNavigation).WithMany(p => p.PeripheralDevices)
                .HasForeignKey(d => d.ConnectedTo)
                .HasConstraintName("peripheral_devices_connected_to_fkey");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("supplies_pkey");

            entity.ToTable("supplies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountOf).HasColumnName("count_of");
            entity.Property(e => e.TypeOf)
                .HasMaxLength(100)
                .HasColumnName("type_of");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .HasColumnName("department");
            entity.Property(e => e.UserLastName)
                .HasMaxLength(50)
                .HasColumnName("user_last_name");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPosition)
                .HasMaxLength(50)
                .HasColumnName("user_position");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
