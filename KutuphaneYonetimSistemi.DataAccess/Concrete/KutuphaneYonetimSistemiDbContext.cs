using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Concrete;
using KutuphaneYonetimSistemi.Entities.Mapping;

namespace KutuphaneYonetimSistemi.DataAccess.Concrete
{
    public class KutuphaneYonetimSistemiDbContext:DbContext
    {
        public KutuphaneYonetimSistemiDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Ceza> Tbl_Ceza { get; set; }
        public DbSet<Hareket> Tbl_Hareket { get; set; }
        public DbSet<Kasa> Tbl_Kasa { get; set; }
        public DbSet<Kategori> Tbl_Kategori { get; set; }
        public DbSet<Kitap> Tbl_Kitap { get; set; }
        public DbSet<Personel> Tbl_Personel { get; set; }
        public DbSet<Uye> Tbl_Uye { get; set; }
        public DbSet<Yazar> Tbl_Yazar { get; set; }
        public DbSet<Duyuru> Tbl_Duyuru { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Uye>().HasMany(c => c.Cezalar).WithRequired(c => c.Uyesi).HasForeignKey(c => c.UyeId);
            modelBuilder.Entity<Hareket>().HasMany(c => c.Cezalar).WithRequired(c => c.Hareketi)
                .HasForeignKey(c => c.HareketId);
            modelBuilder.Entity<Kategori>().HasMany(c => c.Kitaplari).WithRequired(c => c.Kategorisi)
                .HasForeignKey(c => c.KategoriId);
            modelBuilder.Entity<Kitap>().HasMany(c => c.Hareketleri).WithRequired(c => c.Kitabi)
                .HasForeignKey(c => c.KitapId);
            modelBuilder.Entity<Uye>().HasMany(c => c.Hareketler).WithRequired(c => c.Uyesi)
                .HasForeignKey(c => c.UyeId);
            modelBuilder.Entity<Personel>().HasMany(c => c.Hareketler).WithRequired(c => c.Personeli)
                .HasForeignKey(c => c.PersonelId);
            modelBuilder.Entity<Yazar>().HasMany(c => c.Kitaplari).WithRequired(c => c.Yazari)
                .HasForeignKey(c => c.YazarId);

            modelBuilder.Configurations.Add(new CezaMap());
            modelBuilder.Configurations.Add(new HareketMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new DuyuruMap());

        }
    }
}
