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