using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Entities.Mapping
{
    public class KitapMap:EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Ad).HasMaxLength(150).IsRequired();
            this.Property(c => c.BasimYili).HasMaxLength(4).IsRequired();
            this.Property(c => c.SayfaSayisi).IsRequired();
            this.Property(c => c.YayinEvi).HasMaxLength(100).IsRequired();
            this.Property(c => c.KategoriId).IsRequired();
            this.Property(c => c.YazarId).IsRequired();
            this.Property(c => c.Durum).IsRequired();
            this.Property(c => c.KitapFotoUrl).IsOptional().HasMaxLength(500);

            this.ToTable("Tbl_Kitap");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Ad).HasColumnName("Ad");
            this.Property(c => c.BasimYili).HasColumnName("BasimYili");
            this.Property(c => c.SayfaSayisi).HasColumnName("SayfaSayisi");
            this.Property(c => c.YayinEvi).HasColumnName("YayinEvi");
            this.Property(c => c.Durum).HasColumnName("Durum");
            this.Property(c => c.KitapFotoUrl).HasColumnName("KitapFotoUrl");
            this.Property(c => c.KategoriId).HasColumnName("KategoriId");
            this.Property(c => c.YazarId).HasColumnName("YazarId");
        }
    }
}
