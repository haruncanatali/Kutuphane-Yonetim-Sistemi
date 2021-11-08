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
    public class YazarMap:EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Ad).IsRequired().HasMaxLength(50);
            this.Property(c => c.Soyad).IsRequired().HasMaxLength(50);
            this.Property(c => c.Detay).IsOptional().HasMaxLength(2500);

            this.ToTable("Tbl_Yazar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Ad).HasColumnName("Ad");
            this.Property(c => c.Soyad).HasColumnName("Soyad");
            this.Property(c => c.Detay).HasColumnName("Detay");
        }
    }
}
