﻿// <auto-generated />
using System;
using Manchester_City.Models.dbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Manchester_City.Migrations
{
    [DbContext(typeof(ManchesterCityContext))]
    partial class ManchesterCityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Manchester_City.Models.dbModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Notificaciones")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Equipo", b =>
                {
                    b.Property<int>("IdEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipo"), 1L, 1);

                    b.Property<string>("LogoEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEquipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdEquipo");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.FotoEquipo", b =>
                {
                    b.Property<int>("IdFotoEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFotoEquipo"), 1L, 1);

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("date");

                    b.Property<string>("FotoEquipo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FotoEquipo");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdFotoEquipo");

                    b.HasIndex("IdUsuario");

                    b.ToTable("FotoEquipo");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Jugador", b =>
                {
                    b.Property<int>("IdJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJugador"), 1L, 1);

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("date");

                    b.Property<string>("FotoJugador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPosicion")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumeroJugador")
                        .HasColumnType("int");

                    b.HasKey("IdJugador");

                    b.HasIndex("IdPosicion");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Noticium", b =>
                {
                    b.Property<int>("IdNoticia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNoticia"), 1L, 1);

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("date");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("ImagenNoticia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdNoticia");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Noticia");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Partido", b =>
                {
                    b.Property<int>("IdPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPartido"), 1L, 1);

                    b.Property<string>("DatoImportante")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaMod")
                        .HasColumnType("date");

                    b.Property<int>("IdEquipoLocal")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipoVisitante")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("ResultadoLocal")
                        .HasColumnType("int");

                    b.Property<int?>("ResultadoVisitante")
                        .HasColumnType("int");

                    b.HasKey("IdPartido");

                    b.HasIndex("IdEquipoLocal");

                    b.HasIndex("IdEquipoVisitante");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Partido");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Posicion", b =>
                {
                    b.Property<int>("IdPosicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPosicion"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdPosicion");

                    b.ToTable("Posicion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.FotoEquipo", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("FotoEquipos")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_FotoEquipo_Usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Jugador", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.Posicion", "IdPosicionNavigation")
                        .WithMany("Jugadors")
                        .HasForeignKey("IdPosicion")
                        .IsRequired()
                        .HasConstraintName("FK_Jugador_Usuario");

                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Jugadors")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Jugador_Usuario1");

                    b.Navigation("IdPosicionNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Noticium", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Noticia")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Noticia_Usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Partido", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.Equipo", "IdEquipoLocalNavigation")
                        .WithMany("PartidoIdEquipoLocalNavigations")
                        .HasForeignKey("IdEquipoLocal")
                        .IsRequired()
                        .HasConstraintName("FK_Partido_Equipo1");

                    b.HasOne("Manchester_City.Models.dbModels.Equipo", "IdEquipoVisitanteNavigation")
                        .WithMany("PartidoIdEquipoVisitanteNavigations")
                        .HasForeignKey("IdEquipoVisitante")
                        .IsRequired()
                        .HasConstraintName("FK_Partido_Equipo");

                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", "IdUsuarioNavigation")
                        .WithMany("Partidos")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Partido_Usuario1");

                    b.Navigation("IdEquipoLocalNavigation");

                    b.Navigation("IdEquipoVisitanteNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Manchester_City.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.ApplicationUser", b =>
                {
                    b.Navigation("FotoEquipos");

                    b.Navigation("Jugadors");

                    b.Navigation("Noticia");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Equipo", b =>
                {
                    b.Navigation("PartidoIdEquipoLocalNavigations");

                    b.Navigation("PartidoIdEquipoVisitanteNavigations");
                });

            modelBuilder.Entity("Manchester_City.Models.dbModels.Posicion", b =>
                {
                    b.Navigation("Jugadors");
                });
#pragma warning restore 612, 618
        }
    }
}
