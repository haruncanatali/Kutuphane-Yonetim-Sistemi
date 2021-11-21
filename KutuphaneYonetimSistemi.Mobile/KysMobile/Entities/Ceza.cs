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
    public class Ceza
    {
        public int Id { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public decimal Para { get; set; }

        public int UyeId { get; set; }
        public int HareketId { get; set; }

        public Uye Uyesi { get; set; }
        public Hareket Hareketi { get; set; }
    }
}