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
using Android.Graphics;
using KysMobile.Entities;
using KysMobile.Model;

namespace KysMobile.Adapters
{
    public class KitaplarAdapter : BaseAdapter<Kitap>
    {
        List<Kitap> kitapListesi;
        private Context context;

        public KitaplarAdapter(Context context, List<Kitap> kitapListesi)
        {
            this.context = context;
            this.kitapListesi = kitapListesi;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir = convertView;

            satir = LayoutInflater.From(context).Inflate(Resource.Layout.kitap_listesi_satir, null, false);

            TextView kitapAdiText, kategoriAdiText, yazarAdiSoyadiText, yayinEviText, sayfaSayisiText, kitapDurumuText;
            ImageView kitapFotoImg;

            kitapAdiText = satir.FindViewById<TextView>(Resource.Id.kitapAdiTxt);
            kategoriAdiText = satir.FindViewById<TextView>(Resource.Id.kategoriAdiTxt);
            yazarAdiSoyadiText = satir.FindViewById<TextView>(Resource.Id.yazarAdiSoyadiTxt);
            yayinEviText = satir.FindViewById<TextView>(Resource.Id.yayinEviTxt);
            sayfaSayisiText = satir.FindViewById<TextView>(Resource.Id.sayfaSayisiTxt);
            kitapDurumuText = satir.FindViewById<TextView>(Resource.Id.kitapDurumuTxt);
            kitapFotoImg = satir.FindViewById<ImageView>(Resource.Id.kitapResmiImg);

            kitapAdiText.Text = kitapListesi[position].Ad;
            kategoriAdiText.Text = kitapListesi[position].Kategorisi.Ad;
            yazarAdiSoyadiText.Text = kitapListesi[position].Yazari.Ad + " " + kitapListesi[position].Yazari.Soyad;
            yayinEviText.Text = kitapListesi[position].YayinEvi;
            sayfaSayisiText.Text = kitapListesi[position].SayfaSayisi.ToString();

            kitapDurumuText.Text = kitapListesi[position].Durum == false ? "Rafta" : "Okurda";
            kitapDurumuText.SetTextColor(kitapDurumuText.Text == "Rafta" ? Color.Green : Color.Red);

            kitapFotoImg.SetImageBitmap(ImgHelper.LogoTanimla(kitapListesi[position].KitapFotoUrl));

            return satir;

        }

        public override int Count
        {
            get { return kitapListesi.Count; }
        }

        public override Kitap this[int position]
        {
            get { return kitapListesi[position]; }
        }
    }
}