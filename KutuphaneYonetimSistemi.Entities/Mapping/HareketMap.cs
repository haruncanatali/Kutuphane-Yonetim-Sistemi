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
    public class HareketMap:EntityTypeConfiguration<Hareket>
    {
        public HareketMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.AlisTarihi).IsRequired();
            this.Property(c => c.IadeTarihi).IsRequired();
            this.Property(c => c.KitapId).IsRequired();
            this.Property(c => c.UyeId).IsRequired();
            this.Property(c => c.PersonelId).IsRequired();

            this.ToTable("Tbl_Hareket");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.AlisTarihi).HasColumnName("AlisTarihi");
            this.Property(c => c.IadeTarihi).HasColumnName("IadeTarihi");
            this.Property(c => c.KitapId).HasColumnName("KitapId");
            this.Property(c => c.UyeId).HasColumnName("UyeId");
            this.Property(c => c.PersonelId).HasColumnName("PersonelId");
        }
    }
}
