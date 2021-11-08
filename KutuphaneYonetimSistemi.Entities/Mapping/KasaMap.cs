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
    public class KasaMap:EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Ay).IsRequired().HasMaxLength(20);
            this.Property(c => c.Yil).IsRequired().HasMaxLength(4);
            this.Property(c => c.Tutar).IsRequired().HasPrecision(18, 2);

            this.ToTable("Tbl_Kasa");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Ay).HasColumnName("Ay");
            this.Property(c => c.Yil).HasColumnName("Yil");
            this.Property(c => c.Tutar).HasColumnName("Tutar");
        }
    }
}
