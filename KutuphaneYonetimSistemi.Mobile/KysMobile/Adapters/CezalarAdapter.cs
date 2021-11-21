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
    public class CezalarAdapter:BaseAdapter<Ceza>
    {
        private List<Ceza> cezaList;
        private Context context;

        public CezalarAdapter(Context context,List<Ceza> cezaList)
        {
            this.context = context;
            this.cezaList = cezaList;
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir = convertView;
            satir = LayoutInflater.From(context).Inflate(Resource.Layout.ceza_listesi_satir, null, false);

            TextView paraText, tarihAraligiText, hareketIdText;
            ImageView cezaLogo;

            paraText = satir.FindViewById<TextView>(Resource.Id.cezaParaTxt);
            tarihAraligiText = satir.FindViewById<TextView>(Resource.Id.tarihAraligiTxt);
            hareketIdText = satir.FindViewById<TextView>(Resource.Id.hareketIdTxt);
            cezaLogo = satir.FindViewById<ImageView>(Resource.Id.cezaLogoImg);

            cezaLogo.SetImageBitmap(ImgHelper.LogoTanimla(DbAnahtarTablosu.CezaLogoPath));

            paraText.Text = cezaList[position].Para.ToString() + " TL";
            tarihAraligiText.Text = cezaList[position].BaslangicTarihi.ToString("yy-MMM-dd ddd") + " - " +
                                    cezaList[position].BitisTarihi.ToString("yy-MMM-dd ddd");
            hareketIdText.Text = cezaList[position].HareketId.ToString();

            return satir;
        }

        public override int Count
        {
            get { return cezaList.Count; }
        }

        public override Ceza this[int position]
        {
            get { return cezaList[position]; }
        }
    }
}