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
using Android.Graphics.Drawables;
using KysMobile.Entities;
using KysMobile.Model;

namespace KysMobile.Activities
{
    [Activity(Label = "Anasayfa")]
    public class Anasayfa : Activity
    {
        private Button profilBtn,hareketBtn,cezaBtn,duyuruBtn,kitapBtn,personelBtn,cikisBtn;
        private Uye u = LoginUser.uye;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.ana_sayfa);

            Tanimla();
        }

        private void Tanimla()
        {
            profilBtn = FindViewById<Button>(Resource.Id.profilBtn);
            hareketBtn = FindViewById<Button>(Resource.Id.hareketBtn);
            cezaBtn = FindViewById<Button>(Resource.Id.cezaBtn);
            duyuruBtn = FindViewById<Button>(Resource.Id.duyuruBtn);
            kitapBtn = FindViewById<Button>(Resource.Id.kitapBtn);
            personelBtn = FindViewById<Button>(Resource.Id.personelBtn);
            cikisBtn = FindViewById<Button>(Resource.Id.cikisBtn);

            profilBtn.Click += ProfilBtn_Click;
            hareketBtn.Click += HareketBtn_Click;
            cezaBtn.Click += CezaBtn_Click;
            duyuruBtn.Click += DuyuruBtn_Click;
            kitapBtn.Click += KitapBtn_Click;
            personelBtn.Click += PersonelBtn_Click;
            cikisBtn.Click += CikisBtn_Click;
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            LoginUser.uye = null;
            StartActivity(typeof(MainActivity));
        }

        private void PersonelBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Personel));
        }

        private void KitapBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Kitaplar));
        }

        private void DuyuruBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Duyurular));
        }

        private void CezaBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Cezalar));
        }

        private void HareketBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Hareketler));
        }

        private void ProfilBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Profilim));
        }
    }
}