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
using KysMobile.Entities;
using KysMobile.Model;

namespace KysMobile.Adapters
{
    public class DuyurularAdapter:BaseAdapter<Duyuru>
    {
        private Context context;
        private List<Duyuru> duyuruList;

        public DuyurularAdapter(Context context,List<Duyuru> duyuruList)
        {
            this.context = context;
            this.duyuruList = duyuruList;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir=convertView;
            satir = LayoutInflater.From(context).Inflate(Resource.Layout.duyuru_listesi_satir, null, false);

            ImageView duyuruLogoImageView;
            TextView duyuruTarihiText, duyuruIcerikText;

            duyuruLogoImageView = satir.FindViewById<ImageView>(Resource.Id.duyuruLogoImg);
            duyuruLogoImageView.SetImageBitmap(ImgHelper.LogoTanimla(DbAnahtarTablosu.DuyuruLogoPath));

            duyuruTarihiText = satir.FindViewById<TextView>(Resource.Id.duyuruTarihTxt);
            duyuruIcerikText = satir.FindViewById<TextView>(Resource.Id.duyuruDetayTxt);

            duyuruTarihiText.Text = duyuruList[position].Tarih.ToString("D");
            duyuruIcerikText.Text = duyuruList[position].Aciklama;

            return satir;
        }

        public override int Count
        {
            get { return duyuruList.Count; }
        }

        public override Duyuru this[int position]
        {
            get { return duyuruList[position]; }
        }
    }
}