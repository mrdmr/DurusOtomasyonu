using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public partial class DurusOtomasyonuContext : DbContext
    {
        public DurusOtomasyonuContext()
        {
        }

        public DurusOtomasyonuContext(DbContextOptions<DurusOtomasyonuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ariza> Arizas { get; set; }
        public virtual DbSet<ArizaDetay> ArizaDetays { get; set; }
        public virtual DbSet<ArizaTur> ArizaTurs { get; set; }
        public virtual DbSet<Bolum> Bolums { get; set; }
        public virtual DbSet<CalismaSaat> CalismaSaats { get; set; }
        public virtual DbSet<Makine> Makines { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Uretim> Uretims { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DurusOtomasyonu;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ariza>(entity =>
            {
                entity.ToTable("Ariza");

                entity.Property(e => e.DurusBaslama).HasColumnType("datetime");

                entity.Property(e => e.DurusBitis).HasColumnType("datetime");

                entity.Property(e => e.TotalTime).HasColumnType("datetime");

                entity.HasOne(d => d.ArizaDetay)
                    .WithMany(p => p.Arizas)
                    .HasForeignKey(d => d.ArizaDetayId)
                    .HasConstraintName("FK_Ariza_ArizaDetay");

                entity.HasOne(d => d.ArizaTur)
                    .WithMany(p => p.Arizas)
                    .HasForeignKey(d => d.ArizaTurId)
                    .HasConstraintName("FK_Ariza_ArizaTur");

                entity.HasOne(d => d.Makine)
                    .WithMany(p => p.Arizas)
                    .HasForeignKey(d => d.MakineId)
                    .HasConstraintName("FK_Ariza_Makine");

                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Arizas)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("FK_Ariza_Personel");
            });

            modelBuilder.Entity<ArizaDetay>(entity =>
            {
                entity.ToTable("ArizaDetay");

                entity.Property(e => e.Detay).HasMaxLength(50);
            });

            modelBuilder.Entity<ArizaTur>(entity =>
            {
                entity.ToTable("ArizaTur");

                entity.Property(e => e.ArizaAd).HasMaxLength(50);
            });

            modelBuilder.Entity<Bolum>(entity =>
            {
                entity.ToTable("Bolum");

                entity.Property(e => e.BolumAd).HasMaxLength(50);
            });

            modelBuilder.Entity<CalismaSaat>(entity =>
            {
                entity.ToTable("CalismaSaat");

                entity.Property(e => e.BaslangicSaati).HasColumnType("datetime");

                entity.Property(e => e.BitisSaati).HasColumnType("datetime");
            });

            modelBuilder.Entity<Makine>(entity =>
            {
                entity.ToTable("Makine");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PersonelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Serial).HasMaxLength(50);

                entity.HasOne(d => d.Bolum)
                    .WithMany(p => p.Makines)
                    .HasForeignKey(d => d.BolumId)
                    .HasConstraintName("FK_Makine_Bolum");

                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Makines)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("FK_Makine_Personel");
            });

            modelBuilder.Entity<OperationClaim>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.ToTable("Personel");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Verimlilik).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Uretim>(entity =>
            {
                entity.ToTable("Uretim");

                entity.Property(e => e.NormalPeriod).HasColumnType("time(0)");

                entity.Property(e => e.PeriodFark).HasColumnType("time(0)");

                entity.Property(e => e.SabitPeriod).HasColumnType("time(0)");

                entity.Property(e => e.Verim).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("Urun");

                entity.Property(e => e.UrunId).ValueGeneratedNever();

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(500);

                entity.Property(e => e.PasswordSalt).HasMaxLength(500);
            });

            modelBuilder.Entity<UserOperationClaim>(entity =>
            {
                entity.HasOne(d => d.OperationClaim)
                    .WithMany(p => p.UserOperationClaims)
                    .HasForeignKey(d => d.OperationClaimId)
                    .HasConstraintName("FK_UserOperationClaims_OperationClaims");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOperationClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserOperationClaims_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
