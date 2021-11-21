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
using Android.Media;
using KysMobile.Entities;
using KysMobile.Model;

namespace KysMobile.Adapters
{
    public class PersonellerAdapter:BaseAdapter<Personel>
    {
        private Context context;
        private List<Personel> personelList;

        public PersonellerAdapter(Context context,List<Personel> personelList)
        {
            this.context = context;
            this.personelList = personelList;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir = convertView;
            satir = LayoutInflater.From(context).Inflate(Resource.Layout.personel_listesi_satir, null, false);

            TextView personelAdSoyadText, personelTelefonText;
            ImageView personelLogoImageView;

            personelAdSoyadText = satir.FindViewById<TextView>(Resource.Id.personelAdTxt);
            personelTelefonText = satir.FindViewById<TextView>(Resource.Id.telefonTxtPersonel);
            personelLogoImageView = satir.FindViewById<ImageView>(Resource.Id.personelLogoImg);

            personelAdSoyadText.Text = personelList[position].Ad + " " + personelList[position].Soyad;
            personelTelefonText.Text = personelList[position].Telefon;

            personelLogoImageView.SetImageBitmap(ImgHelper.LogoTanimla(DbAnahtarTablosu.PersonelLogoPath));

            return satir;
        }

        public override int Count
        {
            get { return personelList.Count; }
        }

        public override Personel this[int position]
        {
            get { return personelList[position]; }
        }
    }
}