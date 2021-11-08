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
    public class DuyuruMap:EntityTypeConfiguration<Duyuru>
    {
        public DuyuruMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tarih).IsRequired();
            this.Property(c => c.Aciklama).IsRequired().HasMaxLength(500);

            this.ToTable("Tbl_Duyuru");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tarih).HasColumnName("Tarih");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
