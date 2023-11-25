using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Manchester_City.Models.dbModels
{
    public partial class ManchesterCityContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ManchesterCityContext()
        {
        }

        public ManchesterCityContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<FotoEquipo> FotoEquipos { get; set; } = null!;
        public virtual DbSet<Jugador> Jugadors { get; set; } = null!;
        public virtual DbSet<Noticium> Noticia { get; set; } = null!;
        public virtual DbSet<Partido> Partidos { get; set; } = null!;
        public virtual DbSet<Posicion> Posicions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                string conn = "Server=.\\SQLEXPRESS01;Database=ManchesterCityGenerada;Trusted_Connection=True;MultipleActiveResultSets=true";

                builder.UseSqlServer(conn);
            }

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FotoEquipo>(entity =>
            {
                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FotoEquipos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FotoEquipo_Usuario");
            });

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.HasOne(d => d.IdPosicionNavigation)
                    .WithMany(p => p.Jugadors)
                    .HasForeignKey(d => d.IdPosicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jugador_Usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Jugadors)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jugador_Usuario1");
            });

            modelBuilder.Entity<Noticium>(entity =>
            {
                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Noticia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Noticia_Usuario");
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasOne(d => d.IdEquipoLocalNavigation)
                    .WithMany(p => p.PartidoIdEquipoLocalNavigations)
                    .HasForeignKey(d => d.IdEquipoLocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partido_Equipo1");

                entity.HasOne(d => d.IdEquipoVisitanteNavigation)
                    .WithMany(p => p.PartidoIdEquipoVisitanteNavigations)
                    .HasForeignKey(d => d.IdEquipoVisitante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partido_Equipo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partido_Usuario1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
