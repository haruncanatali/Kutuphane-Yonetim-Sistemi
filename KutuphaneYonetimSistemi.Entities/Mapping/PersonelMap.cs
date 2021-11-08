using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Entities.Mapping
{
    public class PersonelMap:EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Ad).IsRequired().HasMaxLength(50);
            this.Property(c => c.Soyad).IsRequired().HasMaxLength(50);
            this.Property(c => c.Tckn).IsRequired().HasMaxLength(11);
            this.Property(c => c.Telefon).IsRequired().HasMaxLength(20);
            this.Property(c => c.Adres).IsRequired().HasMaxLength(350);
            this.Property(c => c.KullaniciAdi).IsRequired().HasMaxLength(15);
            this.Property(c => c.Sifre).IsRequired().HasMaxLength(15);

            this.ToTable("Tbl_Personel");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Ad).HasColumnName("Ad");
            this.Property(c => c.Soyad).HasColumnName("Soyad");
            this.Property(c => c.Tckn).HasColumnName("Tckn");
            this.Property(c => c.Telefon).HasColumnName("Telefon");
            this.Property(c => c.Adres).HasColumnName("Adres");
            this.Property(c => c.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(c => c.Sifre).HasColumnName("Sifre");
        }
    }
}
