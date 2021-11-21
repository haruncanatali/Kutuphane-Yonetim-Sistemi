using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.API.Entities
{
    public class Yazar
    {
        public Yazar()
        {
            Kitaplari = new List<Kitap>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Detay { get; set; }

        public List<Kitap> Kitaplari { get; set; }
    }
}
