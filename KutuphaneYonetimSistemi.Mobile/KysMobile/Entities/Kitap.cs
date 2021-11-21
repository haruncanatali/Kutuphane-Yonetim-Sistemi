using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KysMobile.Entities
{
    public class Kitap
    {
        public Kitap()
        {
            Hareketleri = new List<Hareket>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string BasimYili { get; set; } //char(4)
        public string YayinEvi { get; set; }
        public short SayfaSayisi { get; set; } // smallint
        public bool Durum { get; set; }
        public string KitapFotoUrl { get; set; }

        public int KategoriId { get; set; }
        public int YazarId { get; set; }

        public virtual Kategori Kategorisi { get; set; }
        public virtual Yazar Yazari { get; set; }
        public virtual List<Hareket> Hareketleri { get; set; }
    }
}