using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyASPNetCoreAdmin.Models;

public partial class DbseguimientoGastosContext : DbContext
{
    public DbseguimientoGastosContext()
    {
    }

    public DbseguimientoGastosContext(DbContextOptions<DbseguimientoGastosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administradore> Administradores { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Gasto> Gastos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=NOTE_DERRMAN\\SQLEXPRESS;database=DBSeguimientoGastos;integrated security=true;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administradore>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Administ__B2C3ADE5BA5A8AD7");

            entity.HasIndex(e => e.NombreAdmin, "UQ__Administ__3A0052752689E0EF").IsUnique();

            entity.HasIndex(e => e.Apellidos, "UQ__Administ__7675D77AEFD5D265").IsUnique();

            entity.HasIndex(e => e.Nombres, "UQ__Administ__822604A261853971").IsUnique();

            entity.HasIndex(e => e.Run, "UQ__Administ__C2B74E6C81C5CE7D").IsUnique();

            entity.Property(e => e.IdAdmin)
                .ValueGeneratedOnAdd()
                .HasColumnName("idAdmin");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.ContraseñaAdmin)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contraseñaAdmin");
            entity.Property(e => e.NombreAdmin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nombreAdmin");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Run)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("run");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepto).HasName("PK__Departam__F1B8249B1E726254");

            entity.HasIndex(e => e.NombreDepto, "UQ__Departam__776B810D2B27E349").IsUnique();

            entity.Property(e => e.IdDepto)
                .ValueGeneratedOnAdd()
                .HasColumnName("idDepto");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.NombreDepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombreDepto");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdAdmin)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.IdGasto).HasName("PK__Gastos__F25CC32188F724C9");

            entity.Property(e => e.IdGasto).HasColumnName("idGasto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Detalle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.FechaGasto)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaGasto");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.TipoGasto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoGasto");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.IdAdmin)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__645723A66BE6F7F5");

            entity.HasIndex(e => e.Apellidos, "UQ__Usuarios__7675D77A5A4035D8").IsUnique();

            entity.HasIndex(e => e.Nombres, "UQ__Usuarios__822604A23FF7D36B").IsUnique();

            entity.HasIndex(e => e.Usuario1, "UQ__Usuarios__9AFF8FC631896C7A").IsUnique();

            entity.HasIndex(e => e.Run, "UQ__Usuarios__C2B74E6CCAE1C981").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdDepto).HasColumnName("idDepto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Run)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdAdmin)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdDeptoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdDepto)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
