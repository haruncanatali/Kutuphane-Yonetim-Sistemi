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
    public class CezaMap:EntityTypeConfiguration<Ceza>
    {
        public CezaMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.BaslangicTarihi).IsRequired();
            this.Property(c => c.BitisTarihi).IsRequired();
            this.Property(c => c.Para).IsOptional().HasPrecision(5, 2);
            this.Property(c => c.UyeId).IsRequired();
            this.Property(c => c.HareketId).IsRequired();

            this.ToTable("Tbl_Ceza");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            this.Property(c => c.BitisTarihi).HasColumnName("BitisTarihi");
            this.Property(c => c.Para).HasColumnName("Para");
            this.Property(c => c.UyeId).HasColumnName("UyeId");
            this.Property(c => c.HareketId).HasColumnName("HareketId");
        }
    }
}
