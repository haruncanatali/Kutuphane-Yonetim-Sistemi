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
using Android.Icu.Text;
using KysMobile.Entities;
using KysMobile.Model;

namespace KysMobile.Adapters
{
    public class HareketlerAdapter:BaseAdapter<Hareket>
    {
        private Context context;
        private List<Hareket> hareketList;
        public HareketlerAdapter(Context context, List<Hareket> hareketList)
        {
            this.context = context;
            this.hareketList = hareketList;
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir1 = convertView;
            satir1 = LayoutInflater.From(context).Inflate(Resource.Layout.hareket_listesi_satir, null, false);

            TextView kitapAdiText, alisTarihiText, iadeTarihiText;
            ImageView hareketLogo;

            hareketLogo = satir1.FindViewById<ImageView>(Resource.Id.hareketLogoImg);
            hareketLogo.SetImageBitmap(ImgHelper.LogoTanimla(DbAnahtarTablosu.HareketLogoPath));

            kitapAdiText = satir1.FindViewById<TextView>(Resource.Id.kitapAdiTxt);
            alisTarihiText = satir1.FindViewById<TextView>(Resource.Id.alisTarihiTxt);
            iadeTarihiText = satir1.FindViewById<TextView>(Resource.Id.iadeTarihiTxt);

            kitapAdiText.Text = hareketList[position].Kitabi.Ad;
            alisTarihiText.Text = hareketList[position].AlisTarihi.ToString("yy-MMM-dd ddd");
            iadeTarihiText.Text = hareketList[position].IadeTarihi.ToString("yy-MMM-dd ddd");

            return satir1;
        }

        public override int Count
        {
            get { return hareketList.Count; }
        }

        public override Hareket this[int position]
        {
            get { return hareketList[position]; }
        }
    }
}