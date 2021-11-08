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
    public class KategoriMap:EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Ad).IsRequired().HasMaxLength(50);

            this.ToTable("Tbl_Kategori");
            this.Property(c => c.Id).HasColumnName("Kategori");
            this.Property(c => c.Ad).HasColumnName("Ad");
        }
    }
}
