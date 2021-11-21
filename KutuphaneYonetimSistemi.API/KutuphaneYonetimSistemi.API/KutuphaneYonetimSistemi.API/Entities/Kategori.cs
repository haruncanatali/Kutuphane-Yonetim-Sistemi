using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.API.Entities
{
    public class Kategori
    {
        public Kategori()
        {
            Kitaplari = new List<Kitap>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual List<Kitap> Kitaplari { get; set; }
    }
}
