using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyASPNetCore7Admin.Models;

public partial class DbseguimientoGastosContext : DbContext
{
    public DbseguimientoGastosContext()
    {
    }

    public DbseguimientoGastosContext(DbContextOptions<DbseguimientoGastosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminMantenedore> AdminMantenedores { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Gasto> Gastos { get; set; }

    public virtual DbSet<Presupuesto> Presupuestos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=NOTE_DERRMAN\\SQLEXPRESS;Database=DBSeguimientoGastos;Integrated Security=true;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminMantenedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminMan__3213E83F274853EA");

            entity.HasIndex(e => e.Apellidos, "UQ__AdminMan__7675D77AC6DFDF92").IsUnique();

            entity.HasIndex(e => e.Nombres, "UQ__AdminMan__822604A2C2B00A6C").IsUnique();

            entity.HasIndex(e => e.UsuarioAm, "UQ__AdminMan__A5B264AE91233082").IsUnique();

            entity.HasIndex(e => e.Run, "UQ__AdminMan__C2B74E6C76725975").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.PasswordAm)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("passwordAM");
            entity.Property(e => e.Run)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.UsuarioAm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("usuarioAM");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departam__3213E83FF9F6E9A1");

            entity.HasIndex(e => e.NombreDepto, "UQ__Departam__776B810DF8FC10C1").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.NombreDepto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombreDepto");
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gastos__3213E83F5416B0C2");

            entity.Property(e => e.Id).HasColumnName("id");
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
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.TipoGasto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoGasto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gastos_Usuarios_idUsuario");
        });

        modelBuilder.Entity<Presupuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3213E83FDBC0E0DD");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaDesde)
                .HasColumnType("datetime")
                .HasColumnName("fechaDesde");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("fechaHasta");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.Saldo).HasColumnName("saldo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Usuarios_idUsuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3213E83F71C01B3E");

            entity.HasIndex(e => e.Apellidos, "UQ__Usuarios__7675D77A46B9B8F5").IsUnique();

            entity.HasIndex(e => e.Nombres, "UQ__Usuarios__822604A2B6FADCAA").IsUnique();

            entity.HasIndex(e => e.Usuario1, "UQ__Usuarios__9AFF8FC6F122891A").IsUnique();

            entity.HasIndex(e => e.Run, "UQ__Usuarios__C2B74E6CC19094D7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Run)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdDeptoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdDepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Departamentos_idDepto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
