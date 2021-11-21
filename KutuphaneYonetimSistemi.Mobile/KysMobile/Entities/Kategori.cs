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