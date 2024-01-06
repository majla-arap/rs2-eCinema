using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eCinema.Services.Database
{
    public partial class eCinemaContext : DbContext
    {
        public eCinemaContext()
        {
        }

        public eCinemaContext(DbContextOptions<eCinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cinema> Cinemas { get; set; } = null!;
        public virtual DbSet<Dvorana> Dvoranas { get; set; } = null!;
        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<FilmGlumac> FilmGlumacs { get; set; } = null!;
        public virtual DbSet<FilmZanr> FilmZanrs { get; set; } = null!;
        public virtual DbSet<Glumac> Glumacs { get; set; } = null!;
        public virtual DbSet<Kartum> Karta { get; set; } = null!;
        public virtual DbSet<Korisnik> Korisniks { get; set; } = null!;
        public virtual DbSet<KorisnikUloge> KorisnikUloges { get; set; } = null!;
        public virtual DbSet<Kupovina> Kupovinas { get; set; } = null!;
        public virtual DbSet<Obavijest> Obavijests { get; set; } = null!;
        public virtual DbSet<ObavijestKategorija> ObavijestKategorijas { get; set; } = null!;
        public virtual DbSet<Termin> Termins { get; set; } = null!;
        public virtual DbSet<Uloga> Ulogas { get; set; } = null!;
        public virtual DbSet<Zanr> Zanrs { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B2H7QQK\\MSSQLSERVER_OLAP;Database=eCinema;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.ToTable("Cinema");
            });

            modelBuilder.Entity<Dvorana>(entity =>
            {
                entity.ToTable("Dvorana");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Dvoranas)
                    .HasForeignKey(d => d.CinemaId)
                    .HasConstraintName("FK__Dvorana__CinemaI__33D4B598");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("Film");

                entity.Property(e => e.Godina).HasMaxLength(15);

                entity.Property(e => e.PocetakPrikazivanja).HasColumnType("datetime");
            });

            modelBuilder.Entity<FilmGlumac>(entity =>
            {
                entity.ToTable("FilmGlumac");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmGlumacs)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__FilmGluma__FilmI__412EB0B6");

                entity.HasOne(d => d.Glumac)
                    .WithMany(p => p.FilmGlumacs)
                    .HasForeignKey(d => d.GlumacId)
                    .HasConstraintName("FK__FilmGluma__Gluma__403A8C7D");
            });

            modelBuilder.Entity<FilmZanr>(entity =>
            {
                entity.ToTable("FilmZanr");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmZanrs)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__FilmZanr__FilmId__44FF419A");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.FilmZanrs)
                    .HasForeignKey(d => d.ZanrId)
                    .HasConstraintName("FK__FilmZanr__ZanrId__440B1D61");
            });

            modelBuilder.Entity<Glumac>(entity =>
            {
                entity.ToTable("Glumac");
            });

            modelBuilder.Entity<Kartum>(entity =>
            {
                entity.HasKey(e => e.KartaId)
                    .HasName("PK__Karta__EC3FA9EE350BB06B");

                entity.Property(e => e.Sjediste).IsUnicode(false);

                entity.HasOne(d => d.Termin)
                    .WithMany(p => p.Karta)
                    .HasForeignKey(d => d.TerminId)
                    .HasConstraintName("FK__Karta__TerminId__47DBAE45");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");
            });

            modelBuilder.Entity<KorisnikUloge>(entity =>
            {
                entity.ToTable("KorisnikUloge");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisnikU__Koris__29572725");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__KorisnikU__Uloga__286302EC");
            });

            modelBuilder.Entity<Kupovina>(entity =>
            {
                entity.ToTable("Kupovina");

                entity.Property(e => e.DatumKupovine).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Kupovinas)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Kupovina__Korisn__4AB81AF0");
            });

            modelBuilder.Entity<Obavijest>(entity =>
            {
                entity.ToTable("Obavijest");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Obavijests)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Obavijest__Koris__2F10007B");

                entity.HasOne(d => d.ObavijestKategorija)
                    .WithMany(p => p.Obavijests)
                    .HasForeignKey(d => d.ObavijestKategorijaId)
                    .HasConstraintName("FK__Obavijest__Obavi__2E1BDC42");
            });

            modelBuilder.Entity<ObavijestKategorija>(entity =>
            {
                entity.ToTable("ObavijestKategorija");
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.ToTable("Termin");

                entity.Property(e => e.DatumOdrzavanja).HasColumnType("datetime");

                entity.HasOne(d => d.Dvorana)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.DvoranaId)
                    .HasConstraintName("FK__Termin__DvoranaI__3C69FB99");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__Termin__FilmId__3D5E1FD2");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");
            });

            modelBuilder.Entity<Zanr>(entity =>
            {
                entity.ToTable("Zanr");
            });

            OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
