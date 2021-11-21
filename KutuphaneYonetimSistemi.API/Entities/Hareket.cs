using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.API.Entities
{
    public class Hareket 
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

        public virtual Kitap Kitabi { get; set; }
        public virtual Uye Uyesi { get; set; }
        public virtual List<Ceza> Cezalar { get; set; }
    }
}
