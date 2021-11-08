using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Personel:IEntity
    {
        public Personel()
        {
            Hareketler = new List<Hareket>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckn { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public virtual List<Hareket> Hareketler { get; set; }
    }
}
