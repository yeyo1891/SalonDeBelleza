using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaSalon.Models
{
    public partial class DB_SALONContext : DbContext
    {
        public DB_SALONContext()
        {
        }

        public DB_SALONContext(DbContextOptions<DB_SALONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auditoria> Auditoria { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<DetallePago> DetallePago { get; set; }
        public virtual DbSet<DetalleProducto> DetalleProducto { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=yerson-pc;Database=DB_SALON;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditoria>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria)
                    .HasName("PK__Auditori__9644A3CE2209F55C");

                entity.Property(e => e.IdAuditoria).HasColumnName("id_auditoria");

                entity.Property(e => e.Evento)
                    .HasColumnName("evento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fechahora)
                    .HasColumnName("fechahora")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tabla)
                    .HasColumnName("tabla")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCitas)
                    .HasName("PK__Cita__B0CEEC7CEF5C1458");

                entity.Property(e => e.IdCitas).HasColumnName("id_citas");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Cita__id_cliente__5629CD9C");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdSucursal)
                    .HasConstraintName("FK__Cita__id_sucursa__5535A963");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__FCE039921BB7A97D");

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dpi)
                    .IsRequired()
                    .HasColumnName("DPI")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNac)
                    .HasColumnName("Fecha_nac")
                    .HasColumnType("date");

                entity.Property(e => e.IdTipoCliente).HasColumnName("Id_Tipo_Cliente");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("NIT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cliente__Id_Tipo__5165187F");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PK__Compra__C4BAA60441E028FC");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Compra__id_usuar__52593CB8");
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra)
                    .HasName("PK__detalle___BD16E2790BBFF6EC");

                entity.ToTable("detalle_compra");

                entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdCompra).HasColumnName("id_compra");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.DetalleCompra)
                    .HasForeignKey(d => d.IdCompra)
                    .HasConstraintName("fk_idcompra_det_compra");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleCompra)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("fk_idproducto_det_compra");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.IdDetalleFactura)
                    .HasName("PK__detalle___F6BFE34305C2F5B7");

                entity.ToTable("detalle_factura");

                entity.Property(e => e.IdDetalleFactura).HasColumnName("id_detalle_factura");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.DetalleFactura)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("fk_idfactura_det_factura");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleFactura)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("fk_idproducto_det_factura");
            });

            modelBuilder.Entity<DetallePago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__Detalle___405F9B771EA02B22");

                entity.ToTable("Detalle_pago");

                entity.Property(e => e.IdPago).HasColumnName("Id_pago");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.IdTipoPago).HasColumnName("Id_tipo_pago");

                entity.HasOne(d => d.IdTipoPagoNavigation)
                    .WithMany(p => p.DetallePago)
                    .HasForeignKey(d => d.IdTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_p__Id_ti__4F7CD00D");
            });

            modelBuilder.Entity<DetalleProducto>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK__Detalle___4F1332DE262B2070");

                entity.ToTable("Detalle_Producto");

                entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Disponibilidad).HasColumnName("disponibilidad");

                entity.Property(e => e.IdProducto).HasColumnName("Id_producto");

                entity.Property(e => e.IdProveedor).HasColumnName("Id_proveedor");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK__Detalle_P__Id_pr__5812160E");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.DetalleProducto)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK__Detalle_P__Id_pr__571DF1D5");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PK__Factura__A6DB936262DC8137");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.NumeroFactura)
                    .IsRequired()
                    .HasColumnName("Numero_factura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__Id_clie__5070F446");
            });

            modelBuilder.Entity<GrupoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdGrupoUsuario)
                    .HasName("PK__Grupo_us__7B1AA8613EB14FD9");

                entity.ToTable("Grupo_usuario");

                entity.Property(e => e.IdGrupoUsuario).HasColumnName("id_grupo_usuario");

                entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.GrupoUsuario)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Grupo_usu__id_pe__5441852A");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.GrupoUsuario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Grupo_usu__id_us__534D60F1");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.IdPermiso)
                    .HasName("PK__Permiso__228F224F9512DBEB");

                entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");

                entity.Property(e => e.Permiso1)
                    .IsRequired()
                    .HasColumnName("permiso")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__producto__FF341C0D552F6318");

                entity.ToTable("producto");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipo_producto");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .HasConstraintName("fk_tipoproducto_producto");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__Proveedo__53B6E1A5B99F9256");

                entity.Property(e => e.IdProveedor).HasColumnName("id_Proveedor");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal)
                    .HasName("PK__Sucursal__4C7580137B85F248");

                entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoCliente)
                    .HasName("PK__Tipo_Cli__2482D3CF34FD8371");

                entity.ToTable("Tipo_Cliente");

                entity.Property(e => e.IdTipoCliente).HasColumnName("Id_Tipo_Cliente");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPago)
                    .HasName("PK__Tipo_pag__282027E28C160322");

                entity.ToTable("Tipo_pago");

                entity.Property(e => e.IdTipoPago).HasColumnName("Id_tipo_pago");

                entity.Property(e => e.Decripcion)
                    .HasColumnName("decripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProducto)
                    .HasName("PK__tipo_pro__F5E0BFB8629AFAFF");

                entity.ToTable("tipo_producto");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipo_producto");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__4E3E04AD215D1722");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
