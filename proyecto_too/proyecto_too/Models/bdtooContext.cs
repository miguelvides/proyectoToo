using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace proyecto_too.Models
{
    public partial class bdtooContext : DbContext
    {
        public bdtooContext()
        {
        }

        public bdtooContext(DbContextOptions<bdtooContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Catalogo> Catalogos { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }
        public virtual DbSet<Escuela> Escuelas { get; set; }
        public virtual DbSet<Galerium> Galeria { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<PermisoRole> PermisoRoles { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolUsuario> RolUsuarios { get; set; }
        public virtual DbSet<SolicitudReserva> SolicitudReservas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("server=DESKTOP-9DSSP5T\\SQLEXPRESS; Database=bdtoo; Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("server=DESKTOP-9DSSP5T\\SQLEXPRESS; Database=bdtoo;User ID=sa; Password=Admin123$");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => e.CodigoMateria);

                entity.ToTable("ASIGNATURA");

                entity.Property(e => e.CodigoMateria)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_MATERIA");

                entity.Property(e => e.Ciclo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CICLO");

                entity.Property(e => e.CodEscuela)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COD__ESCUELA");

                entity.Property(e => e.CodigoCarrera)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CARRERA");

                entity.Property(e => e.CorrelativoMateria).HasColumnName("CORRELATIVO_MATERIA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreMateria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MATERIA");

                entity.Property(e => e.PreRequisito).HasColumnName("PRE_REQUISITO");

                entity.Property(e => e.TipoMateria)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_MATERIA");

                entity.Property(e => e.UnidadValorativa).HasColumnName("UNIDAD_VALORATIVA");

                entity.HasOne(d => d.CodEscuelaNavigation)
                    .WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.CodEscuela)
                    .HasConstraintName("FK_ASIGNATU_REFERENCE_ESCUELA");

                entity.HasOne(d => d.CodigoCarreraNavigation)
                    .WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.CodigoCarrera)
                    .HasConstraintName("FK_ASIGNATU_REFERENCE_CARRERA");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_ASIGNATU_REFERENCE_HORARIO");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.CodigoCarrera);

                entity.ToTable("CARRERA");

                entity.Property(e => e.CodigoCarrera)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_CARRERA");

                entity.Property(e => e.NombreCarrera)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CARRERA");
            });

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo);

                entity.ToTable("CATALOGO");

                entity.Property(e => e.IdCatalogo)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CATALOGO");

                entity.Property(e => e.CodigoLocal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_LOCAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CodigoLocalNavigation)
                    .WithMany(p => p.Catalogos)
                    .HasForeignKey(d => d.CodigoLocal)
                    .HasConstraintName("FK_CATALOGO_REFERENCE_LOCAL");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Catalogos)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_CATALOGO_REFERENCE_HORARIO");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.Dui);

                entity.ToTable("DOCENTE");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.ApellidoDocente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_DOCENTE");

                entity.Property(e => e.EstadoActividad)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_ACTIVIDAD");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.NombreDocente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_DOCENTE");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasKey(e => e.CodEscuela);

                entity.ToTable("ESCUELA");

                entity.Property(e => e.CodEscuela)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COD__ESCUELA");

                entity.Property(e => e.NombreEscuela)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ESCUELA");
            });

            modelBuilder.Entity<Galerium>(entity =>
            {
                entity.ToTable("GALERIA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NombreFoto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_FOTO");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.ToTable("HORARIO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dia)
                    .HasColumnType("datetime")
                    .HasColumnName("DIA");

                entity.Property(e => e.Hora).HasColumnName("HORA");
            });

            modelBuilder.Entity<Local>(entity =>
            {
                entity.HasKey(e => e.CodigoLocal);

                entity.ToTable("LOCAL");

                entity.Property(e => e.CodigoLocal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_LOCAL");

                entity.Property(e => e.Edificio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EDIFICIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Planta)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PLANTA");

                entity.Property(e => e.Ubicacion)
                    .IsUnicode(false)
                    .HasColumnName("UBICACION");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Locals)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_LOCAL_REFERENCE_GALERIA");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.IdPermiso);

                entity.ToTable("PERMISO");

                entity.Property(e => e.IdPermiso)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PERMISO");

                entity.Property(e => e.DescripcionPermiso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_PERMISO");

                entity.Property(e => e.NamePermiso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME_PERMISO");

                entity.Property(e => e.SlugPermiso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLUG_PERMISO");
            });

            modelBuilder.Entity<PermisoRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERMISO_ROLES");

                entity.Property(e => e.IdPermiso).HasColumnName("ID_PERMISO");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPermiso)
                    .HasConstraintName("FK_PERMISO__REFERENCE_PERMISO");

                entity.HasOne(d => d.Rol)
                    .WithMany()
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_PERMISO__REFERENCE_ROL");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.CodigoDeReserva);

                entity.ToTable("RESERVA");

                entity.Property(e => e.CodigoDeReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_DE_RESERVA");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.FechaAceptada)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_ACEPTADA");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Dui)
                    .HasConstraintName("FK_RESERVA_REFERENCE_DOCENTE");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("ROL");

                entity.Property(e => e.RolId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROL_ID");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.NombreRol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ROL");

                entity.Property(e => e.SlugRol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLUG_ROL");
            });

            modelBuilder.Entity<RolUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROL_USUARIO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ROL_USUA_REFERENCE_USUARIO");

                entity.HasOne(d => d.Rol)
                    .WithMany()
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_ROL_USUA_REFERENCE_ROL");
            });

            modelBuilder.Entity<SolicitudReserva>(entity =>
            {
                entity.HasKey(e => e.IdSolucitud);

                entity.ToTable("SOLICITUD_RESERVA");

                entity.Property(e => e.IdSolucitud)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SOLUCITUD");

                entity.Property(e => e.Aprobado).HasColumnName("APROBADO");

                entity.Property(e => e.CodigoLocal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_LOCAL");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_INGRESO");

                entity.HasOne(d => d.CodigoLocalNavigation)
                    .WithMany(p => p.SolicitudReservas)
                    .HasForeignKey(d => d.CodigoLocal)
                    .HasConstraintName("FK_SOLICITU_REFERENCE_LOCAL");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.SolicitudReservas)
                    .HasForeignKey(d => d.Dui)
                    .HasConstraintName("FK_SOLICITU_REFERENCE_DOCENTE");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Pasword)
                    .IsUnicode(false)
                    .HasColumnName("PASWORD");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Dui)
                    .HasConstraintName("FK_USUARIO_REFERENCE_DOCENTE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
