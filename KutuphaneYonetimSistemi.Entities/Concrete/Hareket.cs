using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Hareket:IEntity
    {
        public Hareket()
        {
            Cezalar = new List<Ceza>();
        }

        public int Id { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }

        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public int PersonelId { get; set; }

        public virtual Kitap Kitabi{ get; set; }
        public virtual Uye Uyesi{ get; set; }
        public virtual Personel Personeli{ get; set; }
        public virtual List<Ceza> Cezalar { get; set; }
    }
}
