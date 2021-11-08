using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Yazar:IEntity
    {
        public Yazar()
        {
            Kitaplari = new List<Kitap>();
        }

        public int Id { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }
        public string Detay { get; set; }

        public List<Kitap> Kitaplari { get; set; }
    }
}
